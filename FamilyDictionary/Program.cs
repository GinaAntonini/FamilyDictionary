using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>(){
                {"name", "Anna"},
                {"age", "33"}
            });
            myFamily.Add("brother", new Dictionary<string, string>(){
                {"name", "Nick"},
                {"age", "27"}
            });
            myFamily.Add("mom", new Dictionary<string, string>(){
                {"name", "Deb"},
                {"age", "63"}
            });
            myFamily.Add("dad", new Dictionary<string, string>(){
                {"name", "Ed"},
                {"age", "70"}
            });


            foreach (var familyMember in myFamily)
            {
                var title = familyMember.Key;
                var deets = familyMember.Value;
                var buildString = "";

               foreach (var d in deets)
                {
                    if (d.Key == "name")
                        buildString = ($"{d.Value} is my {title} and is ");
                    if (d.Key == "age")
                        buildString += ($"{d.Value} years old.");
                    
                }
                Console.WriteLine(buildString);

            }
        }
    }
}
