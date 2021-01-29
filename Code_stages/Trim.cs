//trim colum names
foreach(DataColumn dc in dt.Columns) // trim column names
{
   dc.ColumnName = dc.ColumnName.Trim();
}

foreach(DataRow dr in dt.Rows) // trim string data
{
  foreach(DataColumn dc in dt.Columns)
  {
      if(dc.DataType == typeof(string))
      {
	 object o = dr[dc];
	 if(!Convert.IsDBNull(o) && o != null) //DB represents a nonexistent value
	 {
	    dr[dc] = o.ToString().Trim();
	 }
      }
  }
}  
