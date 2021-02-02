try
{
	Success=true;
	IsNumeric =true;
	if(dt.Rows.Count>0)
	{
		foreach(DataRow dr in dt.Rows)
		{
			IsNumeric = int.TryParse(dr[field].ToString(), out _);
			if(IsNumeric==false){
				IsNumeric =false;
				break;
			}
		}
	}
}
catch (Exception e)
{
  Success=false;
  IsNumeric =false;
}
