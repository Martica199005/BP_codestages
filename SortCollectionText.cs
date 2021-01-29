//Do conversion from string to int
//input: dt DataTable, Field string, order_desc bool
//output dt_out DataTable, Success bool


try 
{
	dt_out=null;
	Success=true;
	//add column and convert to int
	dt.Columns.Add("StrInt", typeof(int));
	foreach( DataRow dr in dt.Rows){
	 	dr["StrInt"]=Convert.ToInt32(dr[Field]);
		//Console.WriteLine(dr["StrInt"].GetType()); to see the type 
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
