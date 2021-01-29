
//Find line, put try catch

string line;
found="empty";


using(System.IO.StreamReader file =  new System.IO.StreamReader(path_file))
{
   while((line = file.ReadLine()) != null)
   {
      if(line.Contains(word))
      {
		  found=line.Trim();
      }
   }
}
