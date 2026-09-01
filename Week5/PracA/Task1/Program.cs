using System.Collections.Concurrent;

namespace ArraysPrac
{
    class Progress
    {
        static void Main()
        {
            string[]names=new string[10];
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


            foreach(string name in names)
            {
                System.Console.WriteLine(name);
            }

            string longest=names[0];

            foreach(string name in names)
            {
                if (longest.Length < name.Length)
                {
                    longest=name;
                }
            }
            System.Console.WriteLine($"The longest name is {longest}");


            string shortest=names[0];

            foreach(string name in names)
            {
                if (shortest.Length > name.Length)
                {
                    shortest=name;
                }
            }
            System.Console.WriteLine($"The shortest name is {shortest}");

            System.Console.WriteLine("Before sort array is ");
            foreach(string name in names)
            {
                System.Console.WriteLine(name);
            }


            Array.Sort(names);
            System.Console.WriteLine("After sort array is ");
            foreach(string name in names)
            {
                System.Console.WriteLine(name);
            }


            System.Console.WriteLine("Before reverse the array is ");
            foreach(string name in names)
            {
                System.Console.WriteLine(name);
            }

            System.Console.WriteLine("After reverse the array is ");
            Array.Reverse(names);
            foreach(string name in names)
            {
                System.Console.WriteLine(name);
            }


        


            
        }
    }
}