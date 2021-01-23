// CURRENCY CODE C#:

using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;
namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var bankAccounts = new List<Account> {
                new Account { ID = 345678, Balance = 541.27},
                new Account {ID = 1230221,Balance = -1237.44},
                new Account {ID = 346777,Balance = 3532574},
                new Account {ID = 235788,Balance = 1500.033333}
};
            DisplayInExcel(bankAccounts);
        }
        static void DisplayInExcel(IEnumerable<Account> accounts)
        {
            var excelApp = new Excel.Application { Visible = true };
            excelApp.Workbooks.Add();
            Excel._Worksheet workSheet = (Excel.Worksheet)excelApp.ActiveSheet;
            workSheet.Cells[1, "A"] = "ID Number";
            workSheet.Cells[1, "B"] = "Current Balance";
            var row = 1;
            foreach (var acct in accounts)
            {
                row++;
                workSheet.Cells[row, "A"] = acct.ID;
                workSheet.Cells[row, "B"] = acct.Balance;

            }
            workSheet.Range["B2", "B" + row].NumberFormat = "#,###.00 €";
            workSheet.Columns[1].AutoFit();
            workSheet.Columns[2].AutoFit();
        }
    }
    public class Account
    {
        public int ID { get; set; }
        public double Balance { get; set; }
    }
}


---- bold  
-- https://www.youtube.com/watch?v=lHF1WVoy5gs&list=LL&index=11&t=18s
using System;
using Excel=Microsoft.Office.Interop.Excel;

namespace mysheet
{
	class Program
		{ Microsoft.Office.Interop.Excel.Application excel= new Microsoft.Office.Interop.



// C# code for collections in BP

//libraries: System.dll, System.Core.dll, System.Data.DataSetExtensions.dll

//Namespace: System.Linq, System.Data, System.Collections.Generic


//input: inData(ID(number),Name(Text),Sal(Number)) collection, id Text 
// output outData collection


//CODE


outData= new DataTable();
if(inData.Rows.Count>0){
	var result= inData.AsEnumerable().Where(row =>row["ID"].ToString()==value).ToList();
	outData= inData.Clone();
	foreach(var rowItem in result){
		outData.ImportRow(rowItem);
	}
}




----

if (dt.Rows.Count!=0)
{
   //Try to do something here
}




//find line



//List<string> found = new List<string>(); //found.Add(line);
string line;
found="empty";


using(System.IO.StreamReader file =  new System.IO.StreamReader(path_file))
{
   while((line = file.ReadLine()) != null)
   {
      if(line.Contains(word))
      {
		  found=line.Trim();
      }
   }
}




--- dt max min
// aggiusta questo codice 
int minAccountLevel = int.MaxValue;
int maxAccountLevel = int.MinValue;
foreach (DataRow dr in table.Rows)
{
    int accountLevel = dr.Field<int>("AccountLevel");
    minAccountLevel = Math.Min(minAccountLevel, accountLevel);
    maxAccountLevel = Math.Max(maxAccountLevel, accountLevel);
}


---funziona

int minLavel = Convert.ToInt32(dt.Compute("min([AccountLevel])", string.Empty));

//trim col names
foreach(DataColumn dc in dt.Columns) // trim column names
{
   dc.ColumnName = dc.ColumnName.Trim();
}

foreach(DataRow dr in dt.Rows) // trim string data
{
  foreach(DataColumn dc in dt.Columns)
  {
      if(dc.DataType == typeof(string))
      {
	 object o = dr[dc];
	 if(!Convert.IsDBNull(o) && o != null)
	 {
	    dr[dc] = o.ToString().Trim();
	 }
      }
  }
}  



//Try this to insert a dt into a excel
Workbook workbook = new Workbook();
Worksheet sheet = workbook.Worksheets[0];
sheet.InsertDataTable(datatable, true, 1, 1);
workbook.SaveToFile("DataTable2Excel.xlsx", ExcelVersion.Version2013);
















