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


// bold  
// https://www.youtube.com/watch?v=lHF1WVoy5gs&list=LL&index=11&t=18s
using System;
using Excel=Microsoft.Office.Interop.Excel;

namespace mysheet
{
	class Program
		{ Microsoft.Office.Interop.Excel.Application excel= new Microsoft.Office.Interop.




//dt max min
// aggiusta questo codice 
int minAccountLevel = int.MaxValue;
int maxAccountLevel = int.MinValue;
foreach (DataRow dr in table.Rows)
{
    int accountLevel = dr.Field<int>("AccountLevel");
    minAccountLevel = Math.Min(minAccountLevel, accountLevel);
    maxAccountLevel = Math.Max(maxAccountLevel, accountLevel);
}


//funziona

int minLavel = Convert.ToInt32(dt.Compute("min([AccountLevel])", string.Empty));




//Try this to insert a dt into a excel
Workbook workbook = new Workbook();
Worksheet sheet = workbook.Worksheets[0];
sheet.InsertDataTable(datatable, true, 1, 1);
workbook.SaveToFile("DataTable2Excel.xlsx", ExcelVersion.Version2013);
















