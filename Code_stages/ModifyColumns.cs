try 
{
	Exists=false;
	Success=true;
	foreach(DataColumn dc in dt.Columns)
	{
		string ColumnName = dc.ColumnName.ToString();
	 	if(ColumnName=="DIFFERENZA" && ColumnName=="DIFF_F")
			Exists=true;
			dt.Columns["DIFF_F"].SetOrdinal(7);
			dt.Columns.Remove("DIFFERENZA");
			dt.Columns["DIFF_F"].ColumnName = "DIFFERENZA";
			
	 }
}
catch (Exception e)
{
  Success=false;
  Exists=false;

}
