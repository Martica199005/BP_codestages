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
