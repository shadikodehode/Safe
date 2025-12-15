using System;
using System.IO;

class Safe
{
    public static void Main()
    {
        try
        {
            using (StreamReader sr = new StreamReader (@"crack.txt"))
            {
                string? line;
                        
                while ((line = sr.ReadLine()) != null)
                {
                    
                  if(String.IsNullOrEmpty("R"))
                    {
                        Console.WriteLine("success");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("the file could not be read:");
            Console.WriteLine(e.Message);
        }
    }
}




