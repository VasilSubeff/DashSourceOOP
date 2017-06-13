using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;

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

        public List<string> getInputFiles()
        {
            List<string> list = new List<string>();
            var files = Directory.GetFiles(this.InputDirectory).Select(Path.GetFileName).ToArray();

            foreach (var file in files)
            {
                list.Add(file);
            }

            return list;
        }

        public string getTableName(string fileName)
        {
            string tableName = fileName.Substring(0, fileName.LastIndexOf("_"));
            return "DR_" + tableName;
        }

        public void moveToArchive(string fileName)
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
                File.Replace(fullFilePath, fullArchive, fullArchive + "_");
                File.Delete(fullArchive + "_");
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
