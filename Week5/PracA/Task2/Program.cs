using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ListPrac
{
    class Progress
    {
        static void Main()
        {
            List<string> names=new List<string>();
            names.Add("Emily");
            names.Add("Nathan");
            names.Add("Ryan");
            names.Add("Kevin");
            names.Add("Sarah");
            names.Add("Olivia");
            names.Add("Alex");
            names.Add("Mike");
            names.Add("Anna");
            names.Add("Ben");

            names.Remove("Ben");

            names.Add("Jacky");
            names.Insert(1,"Emila");
            names.AddRange(new List<string>
            { "B",
              "Advent"
                
            });

            int index=names.IndexOf("Ryan");
            System.Console.WriteLine(index);

            foreach(string name in names)
            {
                if (name.Contains("n"))
                {
                    System.Console.WriteLine($"This name contain n : {name}");
                }

            }

            int sum=0;
            foreach(string name in names)
            {
                sum=sum+name.Length;
            }
            System.Console.WriteLine($"The sum of length of all names is {sum}");



            string[]names1=new string[10];
            names[0]="David";
            names[1]="Judy";
            names[2]="Lucy";
            names[3]="Tom";
            names[4]="Rebeacca";
            names[5]="Bob";
            names[6]="V";
            names[7]="Max";
            names[8]="Lucia";
            names[9]="Martin";

            List<string> ConvertArray=names1.ToList();

            names.AddRange(ConvertArray);





        }
    }
}