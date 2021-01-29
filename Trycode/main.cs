using System;
using System.Data;



class MainClass {
  public static void Main (string[] args) {
    //char grade="D";
    //float, double, decimal
    string color="red";
   //Console.Write ("Enter your name:");
    //string name=Console.ReadLine();
    //Console.WriteLine("Hello "+name);
    //int num= Convert.ToInt32("5")
    Console.WriteLine("Roses are "+color);
    int [] array= {1,2,3};
    string [] friends= new string[5];
    SayHi();
    Console.WriteLine(cube(2));
    //if(isMale)
    //and && or ||
    //Console.ReadLine();
    using( DataTable dt= new DataTable("Test")){
      dt.Columns.Add("Col1", typeof(string));
      //dt.Rows.Add("col1","col2",...);
      /*
      foreach( DataRow dr in dt.Rows){
        ConsoleWriteLine("Dosage '{0}", dr["Dosage"]);

      } 

      */

      // try{}catch{}
      // catch(Exception e){Console.WriteLine(e.Message)}
      // you can use more catch and also use any catch for different erroros
      // at the end of the catches put finally
      // inheritance class1 : class
      // virtual --> override

    }

  
  }

static void SayHi(){
  Console.Write ("Hello User");
}

static int cube(int num){
  return num*num*num;

}


}
