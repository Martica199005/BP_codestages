//You want to order a DataTable which has a column with numbers but of type string ( ex: "1"), it makes before the conversion from string to int and after that
//it sort the DataTable in decrescent or crescent order
//input: dt DataTable, Field string, order_desc bool
//output dt_out DataTable, Success bool
//Do conversion from string to int

try 
{
	dt_out=null;
	Success=true;
	//add column and convert to int
	dt.Columns.Add("StrInt", typeof(int));
	foreach( DataRow dr in dt.Rows){
	 	dr["StrInt"]=Convert.ToInt32(dr["IntStr"]);
	 }
	// sort collection by field
	string Field="StrInt";
	string order_desc_str="";
	if(order_desc==true)
		order_desc_str=" desc";
	if (dt.Rows.Count!=0)
	{
		DataView dv = dt.DefaultView;
		dv.Sort = Field+order_desc_str;
		 
		dt_out = dv.ToTable();
		// delete temporary column 
		dt_out.Columns.Remove("StrInt");
		
	}
}
catch (Exception e)
{
  Success=false;
  dt_out=null;
}

/*
try 
{
	dt_out=null;
	Success=true;
	string order_desc_str="";
	if(order_desc==true)
		order_desc_str=" desc";
	if (dt.Rows.Count!=0)
	{
		DataView dv = dt.DefaultView;
		dv.Sort = Field+order_desc_str;
		dt_out = dv.ToTable();
		
	}
}
catch (Exception e)
{
  Success=false;
  dt_out=null;
}*/
