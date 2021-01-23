using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel=Microsoft.Office.Interop.Excel;


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
    
    
      
  }

}
