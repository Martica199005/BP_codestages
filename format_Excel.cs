// to modify 


Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
Microsoft.Office.Interop.Excel.Workbook wb = excelApp.Workbooks.Open(path_file);
Microsoft.Office.Interop.Excel.Worksheet workSheet = excelApp.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;


workSheet.Range[start_cell, end_cell].NumberFormat = format;


wb.Close(true);
excelApp.Quit();
