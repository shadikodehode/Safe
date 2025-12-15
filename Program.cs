using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
    class Program
    {
        static void Main(string[] args)
        {

        int number = 0;
        int start = 50;
       
            
         using (StreamReader sr = new("crack.txt"))
        {
            string line; 
            while ((line = sr.ReadLine()) != null)
            {
                if(line.Contains("R"))
                {
                    Console.WriteLine(start+50);
                }
                if (line.Contains("L"))
                {
                    Console.WriteLine(-50);
                }
            }
        }
         
       
            
        }
    }





