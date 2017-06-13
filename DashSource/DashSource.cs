using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashSource
{
    class DashSource
    {
        static void Main(string[] args)
        {
            ////Downloader
            //LogHelper.Log("Downloader START");
            //Downloader downloader = new Downloader();
            //downloader.downloadAttachments();
            //LogHelper.Log("Downloader END");

            //Loader
            LogHelper.Log("Loader START");
            string sourceFilePath = "TX3_TRACKING_13-Jun-2017.csv";
            string tableName = "DR_TX3_TRACKING";

            Loader ldr = new Loader();
            var columnNames = ldr.getTableColumns(tableName);

            var parsedFile = ldr.GetDataTabletFromCSVFile(sourceFilePath);
            ldr.InsertDataIntoSQLServerUsingSQLBulkCopy(parsedFile, tableName, columnNames);
            ldr.moveToArchive(sourceFilePath);
            LogHelper.Log("Loader END");
            
        } 
    }
}
