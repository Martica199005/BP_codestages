#Do conversion from string to int

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
}
