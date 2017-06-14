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
            downloader.downloadAttachments();
            LogHelper.Log("Downloader END");

            //Loader
            LogHelper.Log("Loader START");
            Loader ldr = new Loader();
            var files = ldr.getInputFiles();

            foreach (var file in files)
            {
                LogHelper.Log("Loading " + file);
                tableName = ldr.getTableName(file);
                var columnNames = ldr.getTableColumns(tableName);
                var parsedFile = ldr.GetDataTabletFromCSVFile(file);
                ldr.TruncateTable(tableName);
                ldr.InsertDataIntoSQLServerUsingSQLBulkCopy(parsedFile, tableName, columnNames);
                ldr.moveToArchive(file);
            }
            LogHelper.Log("Loader END");

            //TODO: GUI
            //TODO: Add comments in the classes
        }
    }
}
