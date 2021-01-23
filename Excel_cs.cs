using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel=Microsoft.Office.Interop.Excel;

//Example: when you create a new istance: 
//Excel excel= new Excel(@"path", sheet_number);
//excel.WriteCell(0,0,"Test");
// close the application: excel.Close()


namespace WindowsFormsApp2{
  class Excel{
      string path="";
      _Application excel= new _Excel.Application();
      Workbook wb;
      Worksheet ws;
    
      //To open the Excel
      public Excel(string path, int Sheet){
        this.path=path;
        wb= excel.Workbooks.Open(path);
        ws= excel.Worksheets[Sheet]; // Sheet is the index of the sheets
      }
    
    
      //To read the Excel cell
      public string ReadCell(int i, int j){
        i++; //Excel starts from 1, first cell is 1,1
        j++;
        if(ws.Cells[i,j].Value2 != null)
          return ws.Cells[i,j].Value2;
        else
          return "";
      }
    
      //To write the Excel cell
      public void writeToCell(int i, int j, string s){
        i++; //Excel starts from 1, first cell is 1,1
        j++;
        ws.Cells[i,j].Value2 != s;
      }
    
      //To save the Excel
      public void Save(){
        wb.Save();
      }
    
      public void SaveAs(string path){
        wb.SaveAs(path);
      }
    
      //To close the application
      public void Close(){
        wb.Close();
      }
    
      //To create a new Workbook
      public void CreateNewFile(){
        this.wb= excel.Workbooks.Adds(XlWBATemplate.xlWBATWorksheet);
        this.ws= wb.Worksheets[1];
      }
    
      //To create a new Worksheet
      public void CreateNewSheet(){
        Worksheet tempsheet= wb.worksheets.Add(After: ws);
      }
    
    
      //To select a Worksheet
      public void SelectWorkSheet(int SheetNumber){
        this.ws = wb.Worksheets[SheetNumber];
      }
    
      //To delete a Worksheet
      public void DeleteWorkSheet(int SheetNumber){
        wb.Worksheets[SheetNumber].Delete();
      }
    
    
    //Use : excel.Application.DisplayAlerts = false  
    
    //To read multiple cells
    public string[,] ReadRange(int starti, int straty, int endi, int endy){
      Range range= (Range)ws.Range[ws.Cells[starti, straty],ws.Cells[endi, endy]];
      //obj is an holder for the values
      object[,] holder = range.Value2;
      string[,] returnstring= new string[endi-starti,endy-starty];
      for(int p=1;p<=endi-starti;p++){
        for(int q=1;q<=endy-starty;q++){
          returnstring[p-1,q-1]=holder[p,q].ToString();
        }
      }
      return returnstring;
    }
    
    //To write multiple cells
  }

}
