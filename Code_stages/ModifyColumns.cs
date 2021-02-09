try 
{
	Exists=false;
	Success=true;
	dt_out=null;

	List<string> columnNames = new List<string>();
	foreach(DataColumn dc in dt.Columns)
	{
		string colName=dc.ColumnName.ToString();
		columnNames.Add(colName);
		
	 }
	if(columnNames.Contains("DIFFERENZA") && columnNames.Contains("DIFF_F"))
	{
		Exists=true;
		int index=dt.Columns["DIFFERENZA"].Ordinal;
		DataView dv = dt.DefaultView;
		dt_out = dv.ToTable();
		dt_out.Columns["DIFF_F"].SetOrdinal(index);
		dt_out.Columns.Remove("DIFFERENZA");
		dt_out.Columns["DIFF_F"].ColumnName = "DIFFERENZA";
		
		
	}

}
catch (Exception e)
{
  Success=false;
  Exists=false;
  dt_out=null;


}
