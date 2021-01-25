Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
Microsoft.Office.Interop.Excel.Workbook wb = excelApp.Workbooks.Open(path_file);
//Microsoft.Office.Interop.Excel.Worksheet workSheet = excelApp.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;
Microsoft.Office.Interop.Excel.Worksheet workSheet = (Microsoft.Office.Interop.Excel.Worksheet)wb.Worksheets[Decimal.ToInt32(Sheet_number)]; // define in which worksheet, do you want to add data

if (dt.Rows.Count!=0)
{
	int i,j;
	i=Decimal.ToInt32(start_r);
	j=Decimal.ToInt32(start_c);

	foreach (DataRow dr in dt.Rows)
	{
	 foreach(DataColumn dc in dt.Columns)
		{
			
			workSheet.Cells[i,j] =dr[dc].ToString();
			j++;
			
		}
	i++;
	j=Decimal.ToInt32(start_c);

	}
	
}

excelApp.DisplayAlerts = false;
wb.SaveAs(path_file, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault);
excelApp.Workbooks.Close(); 
excelApp.Quit();
