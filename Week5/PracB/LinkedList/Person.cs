using System;
using System.Collections.Generic;
namespace PracForLinkedList;
public class Person
{
    private double _age;

    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public double Age
    {
        get => _age;
        set
        {
            if (value <= 0.0)
            {
                throw new ArgumentException("Age can't be less than 0");
            }

            _age = value;
        }
    }

    public string FullName => $"{FirstName}, {LastName}";

    public Person(string firstName, string lastName, double age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    public bool IsAdult()
    {
        return Age >= 18;
    }
}

public class Progress
{
    static void Main()
    {
        Person fred = new Person("Fred", "Smith", 21);
        Person jack = new Person("Jack", "Brown", 17);
        Person tom = new Person("Tom", "White", 35);
        Person alice = new Person("Alice", "Green", 18);
        Person bob = new Person("Bob", "Black", 88);
        Person amy = new Person("Amy", "Lee", 28);
        Person john = new Person("John", "King", 45);
        Person lucy = new Person("Lucy", "Hill", 23);
        Person sam = new Person("Sam", "Wood", 16);
        Person emma = new Person("Emma", "Young", 31);

        List<Person> people = new List<Person>();
        people.Add(fred);
        people.Add(jack);
        people.Add(tom);
        people.Add(alice);
        people.Add(bob);
        people.Add(amy);
        people.Add(john);
        people.Add(lucy);
        people.Add(sam);
        people.Add(emma);

        
        LinkedList<Person> linkedPeople = ToLinkedList(people);

        Console.WriteLine("Before sorting:");
        Console.WriteLine(PrintPeople(linkedPeople));

        LinkedList<Person> sortedPeople = SortPeople(linkedPeople);

        Console. WriteLine("After sorting:");
        Console.WriteLine(PrintPeople(sortedPeople));
    }

    public static LinkedList<Person> ToLinkedList(List<Person> people)
    {
        LinkedList<Person> peopleList = new LinkedList<Person>();

        foreach (Person person in people)
        {
            peopleList.AddLast(person);
        }

        return peopleList;
    }
    public static string PrintPeople(LinkedList<Person> people)
    {
        string result = "";
        foreach (Person person in people)
        {
            result += person.FullName + " " + person.Age + Environment.NewLine;
        }

        return result;
    }
    public static LinkedList<Person> SortPeople( LinkedList<Person> people)
    {
        bool swapped;
        do
        {
            swapped=false;
            LinkedListNode<Person>? current= people.First;
            while (current!.Next != null)
            {
                if(current.Value.Age> current.Next.Value.Age)
                {
                    Person temp=current.Value;
                    current.Value=current.Next.Value;
                    current.Next.Value=temp;

                    swapped=true;
                }
                current=current.Next;
            }
        }
        while(swapped);
        return people;
    }
    
}
