using System;

namespace DashSource
{
    class DashSource
    {
        static void Main(string[] args)
        {
            string tableName = "";

            //Downloader
            LogHelper.Log("Downloader START");
            Downloader downloader = new Downloader();
            downloader.getData();
            LogHelper.Log("Downloader END");

            //Loader
            LogHelper.Log("Loader START");
            Loader ldr = new Loader();
            var files = ldr.getInputFiles();

            foreach (var file in files)
            {
                tableName = ldr.getTableName(file);

                if (file.ToLower().Contains("_alert_"))
                {
                    ldr.ConvertAlert(file);
                }
                else
                {
                    ldr.TruncateTable(tableName);
                }

                LogHelper.Log("Loading " + file);
                
                var columnNames = ldr.getTableColumns(tableName);
                var parsedFile = ldr.GetDataTabletFromCSVFile(file);

                ldr.InsertDataIntoSQLServerUsingSQLBulkCopy(parsedFile, tableName, columnNames);
                ldr.MoveToArchive(file);
            }
            LogHelper.Log("Loader END");

            //TODO: Add comments in the classes
            //TODO: Move convert alert to download when IDs added in the HTML
        }
    }
}
