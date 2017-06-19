using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Xml.XPath;
using HtmlAgilityPack;

namespace DashSource
{
    public class Loader
    {
        public string ConnectionString
        {
            get
            {
                return Properties.Settings.Default.ConnectionString;
            }
        }

        public string Delimiter
        {
            get
            {
                return Properties.Settings.Default.Delimiter;
            }
        }

        public string ArchiveDirectory
        {
            get
            {
                return Properties.Settings.Default.archiveDirSetting;
            }
        }

        public string InputDirectory
        {
            get
            {
                return Properties.Settings.Default.inputDirectorySetting;
            }
        }

        internal void ConvertAlert(string file)
        {
            try
            {
                string fullPath = Properties.Settings.Default.inputDirectorySetting + file;
                string outputFile = fullPath + "#" + DateTime.Now.ToString("yyyyMMddhhmmss") + ".output.txt";

                var htmlDoc = new HtmlDocument();
                htmlDoc.Load(fullPath);

                string details = htmlDoc.GetElementbyId("pre").InnerText.Replace(System.Environment.NewLine, ";");
                
                string columns = "DT|TL|CUST|PF|SV|CP|HN|IP|CU|SN|SP|TH|FR|VRS|SD|DET";
                string values = String.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}",
                    DateTime.Now,
                    htmlDoc.GetElementbyId("title").InnerText,
                    htmlDoc.GetElementbyId("customer").InnerText,
                    htmlDoc.GetElementbyId("platform").InnerText,
                    htmlDoc.GetElementbyId("severity").InnerText,
                    htmlDoc.GetElementbyId("component").InnerText,
                    htmlDoc.GetElementbyId("hostname").InnerText,
                    htmlDoc.GetElementbyId("ip").InnerText,
                    htmlDoc.GetElementbyId("user").InnerText,
                    htmlDoc.GetElementbyId("scriptName").InnerText,
                    htmlDoc.GetElementbyId("scriptPath").InnerText,
                    htmlDoc.GetElementbyId("threshold").InnerText,
                    htmlDoc.GetElementbyId("frequency").InnerText,
                    htmlDoc.GetElementbyId("version").InnerText,
                    htmlDoc.GetElementbyId("doc").InnerText,
                    details);               

                File.Delete(fullPath);
                using (StreamWriter writer = new StreamWriter(fullPath))
                {
                    writer.WriteLine(columns);
                    writer.WriteLine(values);
                }
                LogHelper.Log(fullPath + " converted");
            }
            catch (Exception e)
            {
                LogHelper.Log("Cannot convert alert " + e);
                throw;
            }
        }
        public List<string> getInputFiles()
        {
            try
            {
                List<string> list = new List<string>();
                var files = Directory.GetFiles(this.InputDirectory).Select(Path.GetFileName).ToArray();

                foreach (var file in files)
                {
                    list.Add(file);
                }

                if (list.Count > 0)
                {
                    LogHelper.Log("Files found");
                }
                else
                {
                    LogHelper.Log("No files");
                }
                return list;
            }
            catch (Exception e)
            {
                LogHelper.Log("Files cannot be located " + e);
                throw;
            }
        }

        public void TruncateTable(string tableName)
        {
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                string query = "TRUNCATE TABLE " + tableName;
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                LogHelper.Log(String.Format("Table {0} truncated", tableName));
            }
                
        }

        public void AddNewLines(string tableName)
        {
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                string query = string.Format("UPDATE {0} SET DETAILS = REPLACE(DETAILS, ';', CHAR(10))", tableName);
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                LogHelper.Log("New Lines added to details");
            }

        }

        public string getTableName(string fileName)
        {
            string tableName = fileName.Substring(0, fileName.LastIndexOf("_"));
            return "DR_" + tableName;
        }

        public void MoveToArchive(string fileName)
        {
            
            string dirDate = DateTime.Now.ToString("yyyyMMdd");
            string fullArchive = this.ArchiveDirectory + dirDate + "\\" + fileName;
            string fullFilePath = this.InputDirectory + fileName;
            if (!Directory.Exists(this.ArchiveDirectory + dirDate))
            {
                try
                {
                    Directory.CreateDirectory(this.ArchiveDirectory + dirDate);
                    LogHelper.Log("Archive directory created " + this.ArchiveDirectory + dirDate);
                }
                catch (Exception e)
                {
                    LogHelper.Log("Archive directory could not be created " + e);
                    throw;
                }
            }

            try
            {
                File.Move(fullFilePath, fullArchive + "#" + DateTime.Now.ToString("yyyyMMddhhmmss") + ".txt");
                LogHelper.Log("File moved to ARCHIVE " + fullArchive);
            }
            catch (Exception e)
            {
                LogHelper.Log("File could not be moved to ARCHIVE " + e);
                throw;
            }
        }

        public List<string> getTableColumns(string tableName)
        {
            List<string> listOfColumns = new List<string>();

            try
            {
                using (SqlConnection connection = new SqlConnection(this.ConnectionString))
                {
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "select c.name from sys.columns c inner join sys.tables t on t.object_id = c.object_id and t.name = '" + tableName + "' and t.type = 'U'";
                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                listOfColumns.Add(reader.GetString(0));
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {

                LogHelper.Log("Cannot retrieve table columns " + e);
                throw;
            }

            LogHelper.Log("Table columns retrieved");
            return listOfColumns;
        }

        public DataTable GetDataTabletFromCSVFile(string sourceFilePath)
        {
            DataTable pipeData = new DataTable();
            string fullPath = this.InputDirectory + sourceFilePath;

            try
            {
                using (TextFieldParser pipeReader = new TextFieldParser(fullPath))
                {
                    pipeReader.SetDelimiters(new string[] { this.Delimiter });
                    pipeReader.HasFieldsEnclosedInQuotes = true;

                    string[] colFields = pipeReader.ReadFields();
                    foreach (string column in colFields)
                    {
                        DataColumn datecolumn = new DataColumn(column);
                        datecolumn.AllowDBNull = true;
                        pipeData.Columns.Add(datecolumn);
                    }
                    while (!pipeReader.EndOfData)
                    {
                        string[] fieldData = pipeReader.ReadFields();
                        //Making empty value as null.
                        for (int i = 0; i < fieldData.Length; i++)
                        {
                            if (fieldData[i] == "")
                            {
                                fieldData[i] = null;
                            }
                        }
                        pipeData.Rows.Add(fieldData);
                    }
                }
            }
            catch (Exception e)
            {
                LogHelper.Log("Cannot convert file to DataTable " + e);
                throw;
            }

            LogHelper.Log("DataTable initialized");
            return pipeData;
        }

        public void InsertDataIntoSQLServerUsingSQLBulkCopy(DataTable fileData, string tableName, List<string> columnNames)
        {
            try
            {
                using (SqlConnection dbConnection = new SqlConnection(this.ConnectionString))
                {
                    dbConnection.Open();
                    using (SqlBulkCopy s = new SqlBulkCopy(dbConnection))
                    {
                        s.DestinationTableName = tableName;
                        var columns = fileData.Columns;

                        for (int i = 0; i < columns.Count; i++)
                        {
                            s.ColumnMappings.Add(columns[i].ToString(), columnNames[i].ToString());
                        }
                        s.WriteToServer(fileData);
                    }
                }
            }
            catch (Exception e)
            {
                LogHelper.Log("Cannot insert data " + e);
                throw;
            }

            LogHelper.Log("Data inserted");
        }
    }
}
