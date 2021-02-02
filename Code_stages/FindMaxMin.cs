//Input field
//output: Success flag, min_val, max_val 


try 
{
	int minLavel = Convert.ToInt32(dt.Compute("min(["+field+"])", string.Empty));
	int maxLavel = Convert.ToInt32(dt.Compute("max(["+field+"])", string.Empty));


	min_val=minLavel;
	max_val=maxLavel;
	Success=true;
}
catch (Exception e)
{
	Success=false;
	min_val=0;
	max_val=0;
}
