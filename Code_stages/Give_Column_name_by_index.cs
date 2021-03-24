// input: dt (DataTable), index (Number)
// output result (Text)
result="";
Success=true;

try
{
	
	if(dt.Rows.Count>0){
		foreach(DataColumn dc in dt.Columns){
			if (dc.Ordinal == index){
				result=dc.ColumnName;
				}
			}
		
	}
}
catch (Exception e)
{
  Success=false;

}
