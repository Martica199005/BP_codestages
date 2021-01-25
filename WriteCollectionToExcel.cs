// BP Code stage to write a collection to an Excel file, it copies also the empty rows.
//ddl to import: Windows.Forms.dll, Microsoft.Office.Interop.Excel.dll, Syste,Collections.Generic.dll
// Input: dt collection, path_file string, start_r and start_c number, Sheet_number number
// you can also put as namespace imports: Excel= Microsoft.Office.Interop.Excel


Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
Microsoft.Office.Interop.Excel.Workbook wb = excelApp.Workbooks.Open(path_file);
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
			string ColumnName = dc.ColumnName.ToString();
		 	if(i==Decimal.ToInt32(start_r)){
				workSheet.Cells[i,j] =ColumnName;
				j++;
			}
		 	else{
				workSheet.Cells[i,j] =dr[dc].ToString();
				j++;
			}
			}
			
		}
	i++;
	j=Decimal.ToInt32(start_c);

	}
	
}

excelApp.DisplayAlerts = false;
wb.SaveAs(path_file, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault);
excelApp.Workbooks.Close(); 
excelApp.Quit();
