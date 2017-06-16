using System;
using Microsoft.Exchange.WebServices.Data;
using System.IO;
using System.Linq;

namespace DashSource
{
    public  class Downloader
    {
        private string EmailInputFolder
        {
            get
            {
                return Properties.Settings.Default.emailInputFolderSetting;
            }
        }

        private string EmailProcessedFolder
        {
            get
            {
                return Properties.Settings.Default.emailProcessedFolderSetting;
            }
        }

        private string InputDirectory
        {
            get
            {
                return Properties.Settings.Default.inputDirectorySetting;
            }
        }

        private string User
        {
            get
            {
                return Properties.Settings.Default.userSetting;
            }
        }

        private string Password
        {
            get
            {
                return Properties.Settings.Default.passwordSetting;
            }
        }


        public void downloadAttachments()
        {
            //EWS Connection
            ExchangeService service = new ExchangeService(ExchangeVersion.Exchange2007_SP1);
            service.Credentials = new WebCredentials(this.User, this.Password);
            service.UseDefaultCredentials = false;
            //service.TraceEnabled = true;
            //service.TraceFlags = TraceFlags.All;
            service.AutodiscoverUrl(this.User, this.RedirectionUrlValidationCallback);
            Console.WriteLine(service.Url);
            LogHelper.Log("Connected to mailbox");

            //Find folders
            Folder inputFolder = this.findFolder(service, this.EmailInputFolder);
            LogHelper.Log("Found email input fodler");
            Folder processedFolder = this.findFolder(service, this.EmailProcessedFolder);
            LogHelper.Log("Found email processed folder");

            //Find items in input folder
            try
            {

                FindItemsResults<Item> items = service.FindItems(inputFolder.Id, new ItemView(100));
                service.LoadPropertiesForItems(items, PropertySet.FirstClassProperties);
                LogHelper.Log("Emails loaded");
                //Download attachments from found items and move the item to attachments
                foreach (var item in items.Items)
                {
                    if (item.HasAttachments)
                    {
                        this.GetAttachmentsFromEmail(service, item.Id);
                    }
                    else
                    {
                        this.saveEmailBody(service, item.Id);
                        //TODO: spool body to file
                        //TODO: Replace
                    }

                    this.MarkEmailAsRead(service, item.Id);
                    LogHelper.Log("Email marked as Read");
                    item.Move(processedFolder.Id);
                    LogHelper.Log("Email moved to processed");
                }
            }
            catch (Exception e)
            {
                if (e.Message.Contains("destinationFolderId"))
                {
                    LogHelper.Log("Email was not moved. Destination folder incorrect." + e);
                }
                else if (e.Message.Contains("items"))
                {
                    LogHelper.Log("No emails found" +e);
                }
            }
        }
        private Folder findFolder(ExchangeService service, string folderName)
        {
            try
            {
                Folder rootFolder = Folder.Bind(service, WellKnownFolderName.Inbox);
                Folder outputFolder = new Folder(service);
                foreach (var folder in rootFolder.FindFolders(new FolderView(100)))
                {
                    if (folder.DisplayName.Contains(folderName))
                    {
                        outputFolder = Folder.Bind(service, folder.Id);
                    }
                }

                return outputFolder;

            }
            catch (Exception e)
            {

                LogHelper.Log("Email folders cannot be found " + e);
                throw;
            }

            return null;

        }

        private bool RedirectionUrlValidationCallback(string redirectionUrl)
        {
            // The default for the validation callback is to reject the URL.
            bool result = false;

            Uri redirectionUri = new Uri(redirectionUrl);

            // Validate the contents of the redirection URL. In this simple validation
            // callback, the redirection URL is considered valid if it is using HTTPS
            // to encrypt the authentication credentials. 
            if (redirectionUri.Scheme == "https")
            {
                result = true;
            }
            return result;
        }

        private void GetAttachmentsFromEmail(ExchangeService service, ItemId itemId)
        {
            try
            {
                // Bind to an existing message item and retrieve the attachments collection.
                // This method results in an GetItem call to EWS.
                EmailMessage message = EmailMessage.Bind(service, itemId, new PropertySet(ItemSchema.Attachments));

                // Iterate through the attachments collection and load each attachment.
                foreach (Attachment attachment in message.Attachments)
                {
                    if (attachment is FileAttachment)
                    {
                        FileAttachment fileAttachment = attachment as FileAttachment;

                        // Load the attachment into a file.
                        // This call results in a GetAttachment call to EWS.
                        fileAttachment.Load(this.InputDirectory + fileAttachment.Name);

                        LogHelper.Log("File attachment name: " + fileAttachment.Name + " downloaded");
                    }
                    else // Attachment is an item attachment.
                    {
                        ItemAttachment itemAttachment = attachment as ItemAttachment;

                        // Load attachment into memory and write out the subject.
                        // This does not save the file like it does with a file attachment.
                        // This call results in a GetAttachment call to EWS.
                        itemAttachment.Load();
                    }
                }
            }
            catch (Exception e)
            {

                LogHelper.Log("Attachment cannot be downloader" + e);
                throw;
            }
        }

        private void saveEmailBody(ExchangeService service, ItemId itemId)
        {
            try
            {
                var propSet = new PropertySet(ItemSchema.Body);
                propSet.RequestedBodyType = BodyType.Text;
                propSet.BasePropertySet = BasePropertySet.FirstClassProperties;
                EmailMessage message = EmailMessage.Bind(service, itemId, propSet);

                string filePath = Properties.Settings.Default.inputDirectorySetting + message.Subject + ".input";
                string filePathOutput = Properties.Settings.Default.inputDirectorySetting + message.Subject + "-" + DateTime.Now.Hour + DateTime.Now.Minute + ".txt";
                string delimiter = Properties.Settings.Default.Delimiter;
                //string delimiter = ",";
                string line = null;

                using (StreamWriter file = new StreamWriter(filePath))
                {
                    file.WriteLine(message.Body.Text);
                }
                LogHelper.Log(message.Subject + " body downloaded to input file");

                int delimiterCount = File.ReadLines(filePath).First().Count(f => f == delimiter[0]);

                //Remove lines without delimiters
                using (StreamReader reader = new StreamReader(filePath))
                {
                    using (StreamWriter writer = new StreamWriter(filePathOutput))
                    {
                        while ((line = reader.ReadLine()) != null)
                        {
                            int currentDelimiterCount = line.Count(f => f == delimiter[0]);

                            if (currentDelimiterCount == delimiterCount)
                            {
                                writer.WriteLine(line);
                            }
                        }
                    }
                }
                LogHelper.Log(message.Subject + " output file created");
                File.Delete(filePath);
                LogHelper.Log(message.Subject + " input file deleted");
            }
            catch (Exception e)
            {
                LogHelper.Log("Cannot download body " + e);
                throw;
            }
        }

        public void MarkEmailAsRead(ExchangeService service, ItemId itemId)
        {
            try
            {
                EmailMessage email = EmailMessage.Bind(service, itemId, new PropertySet(BasePropertySet.FirstClassProperties, EmailMessageSchema.IsRead));
                email.IsRead = true;
                email.Update(ConflictResolutionMode.AlwaysOverwrite);
            }
            catch (Exception e)
            {
                LogHelper.Log("Cannot mark email as read " + e);
                throw;
            }
        }
    }
}
