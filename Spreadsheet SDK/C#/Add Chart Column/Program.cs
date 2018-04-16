//*****************************************************************************************//
//                                                                                         //
// Download offline evaluation version (DLL): https://bytescout.com/download/web-installer //
//                                                                                         //
// Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   //
//                                                                                         //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               //
// http://www.bytescout.com                                                                //
//                                                                                         //
//*****************************************************************************************//


using System;
using System.Diagnostics;
using Bytescout.Spreadsheet;
using Bytescout.Spreadsheet.Charts;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new Spreadsheet object
            Spreadsheet spreadsheet = new Spreadsheet();
            spreadsheet.RegistrationName = "demo";
            spreadsheet.RegistrationKey = "demo";

            // Add new worksheet
            Worksheet sheet = spreadsheet.Workbook.Worksheets.Add("Sample");

            // Add few random numbers
            int length = 10;
            Random rnd = new Random();
            for (int i = 0; i < length; i++)
            {
                sheet.Cell(i, 0).Value = rnd.Next(10);
                sheet.Cell(i, 1).Value = rnd.Next(10);
            }

            // Add charts to worksheet
            Chart columnChart = sheet.Charts.AddChartAndFitInto(1, 3, 16, 9, ChartType.ColumnClustered);
            columnChart.SeriesCollection.Add(new Series(sheet.Range(0, 0, length - 1, 0)));
            columnChart.SeriesCollection.Add(new Series(sheet.Range(0, 1, length - 1, 1)));

            columnChart = sheet.Charts.AddChartAndFitInto(1, 10, 16, 16, ChartType.ColumnStacked);
            columnChart.SeriesCollection.Add(new Series(sheet.Range(0, 0, length - 1, 0)));
            columnChart.SeriesCollection.Add(new Series(sheet.Range(0, 1, length - 1, 1)));

            columnChart = sheet.Charts.AddChartAndFitInto(1, 17, 16, 23, ChartType.ColumnStacked100);
            columnChart.SeriesCollection.Add(new Series(sheet.Range(0, 0, length - 1, 0)));
            columnChart.SeriesCollection.Add(new Series(sheet.Range(0, 1, length - 1, 1)));

            columnChart = sheet.Charts.AddChartAndFitInto(17, 3, 32, 9, ChartType.ColumnClustered3D);
            columnChart.SeriesCollection.Add(new Series(sheet.Range(0, 0, length - 1, 0)));
            columnChart.SeriesCollection.Add(new Series(sheet.Range(0, 1, length - 1, 1)));

            columnChart = sheet.Charts.AddChartAndFitInto(17, 10, 32, 16, ChartType.ColumnStacked3D);
            columnChart.SeriesCollection.Add(new Series(sheet.Range(0, 0, length - 1, 0)));
            columnChart.SeriesCollection.Add(new Series(sheet.Range(0, 1, length - 1, 1)));

            columnChart = sheet.Charts.AddChartAndFitInto(17, 17, 32, 23, ChartType.ColumnStacked1003D);
            columnChart.SeriesCollection.Add(new Series(sheet.Range(0, 0, length - 1, 0)));
            columnChart.SeriesCollection.Add(new Series(sheet.Range(0, 1, length - 1, 1)));

            columnChart = sheet.Charts.AddChartAndFitInto(33, 10, 48, 16, ChartType.Column3D);
            columnChart.SeriesCollection.Add(new Series(sheet.Range(0, 0, length - 1, 0)));
            columnChart.SeriesCollection.Add(new Series(sheet.Range(0, 1, length - 1, 1)));

            // Save it as XLS
            spreadsheet.SaveAs("Output.xls");

            // Close the document
            spreadsheet.Close();

            // Cleanup
            spreadsheet.Dispose();

            // Open generated XLS file in default associated application
            Process.Start("Output.xls");
        }
    }
}
