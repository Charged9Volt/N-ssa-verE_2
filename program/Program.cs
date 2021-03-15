
using System;
using System.Collections.Generic;

namespace program
{
    class Program
    {
              static void Main(string[] args)
        {
        //Int array 
        int[] numer = {4,2,3,5,7};
        // String Array 
        string[] namn = {"David", "Nicklas", "Max","Chris","Andy"};
        string[] leksaker = {"Bil", "Gosedjur", "Docka", "Tärningar","kort"};

        //String Lista 
        List<string> cities = new List<string>();
         
         int skip = 1;
        while (skip == 1){
        for (int i = 0; i < leksaker.Length; i++)
        {
          // Jag trode att i exemplet "pelle ger Barbie betyget 5" att pelle och Barbie var 2 olika personer....... Det tror att dehär var sättet du tänkte att vi skulle göra dehära.
          Console.WriteLine(namn[i] + " Gav " + leksaker[i] + " " + numer[i] + " i betyg");
          skip = 0;
         }
        }
        
        System.Console.WriteLine("Klicka på enter för nästa moment :)");
        string svar = Console.ReadLine();
        
        int exitKey = 1; 
        while(exitKey == 1 )
        {

          for (int i = 0; i < cities.Count; i++)
          {
            System.Console.WriteLine(cities[i]);   
          }
          System.Console.WriteLine("Skriv städer. exit = stänga programet");
          string exit = Console.ReadLine();

          if(exit == "exit")
          {
            exitKey = 0;
          }
          else
          {
            cities.Add(exit);
          }
          Console.Clear();
        }

        

        }
    }
}
