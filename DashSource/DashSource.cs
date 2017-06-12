﻿using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashSource
{
    class DashSource
    {
        static void Main(string[] args)
        {
            string sourceFilePath = @"C:\Users\vasil\Desktop\Dimo\KPI_Status_12-Jun-2017.csv";
            string tableName = "dr_kpis";

            Loader ldr = new Loader();
            var columnNames = ldr.getTableColumns(tableName);
            
            var parsedFile = ldr.GetDataTabletFromCSVFile(sourceFilePath);
            ldr.InsertDataIntoSQLServerUsingSQLBulkCopy(parsedFile, tableName, columnNames);           
        }
        
    }
}
