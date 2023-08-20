using System;
class Program
{
    static void Main(string[] args)
    {
        //System.Collections.Generic
        //add
        List<string> nameList = new List<string>();
        nameList.Add("John");
        nameList.Add("David");
        nameList.Add("Sophia");
        nameList.Add("Olivia");
        nameList.Add("Mia");

        List<int> numberList = new List<int>();
        numberList.Add(11);
        numberList.Add(29);
        numberList.Add(34);
        numberList.Add(7);
        numberList.Add(5);

        //Count
        Console.WriteLine(nameList.Count);
        Console.WriteLine(numberList.Count);

        //Foreach
        foreach (string name in nameList)
            Console.WriteLine(name);
        foreach (int number in numberList)
            Console.WriteLine(number);

        //remove
        nameList.Remove("Mia");
        numberList.Remove(29);

        //Checking to remove
        numberList.ForEach(number => Console.WriteLine(number));
        nameList.ForEach(name => Console.WriteLine(name));

        //Search from list
        if (numberList.Contains(34))
            Console.WriteLine("34 Found");

        //String[] to List
        string[] Animals = { "Cat", "Dog", "Bird" };
        List<string> animalList = new List<string>(Animals);
        animalList.ForEach(animal => Console.WriteLine(animal));

        //to Clear
        animalList.Clear();

        List<Users> userList = new List<Users>();

        Users user1 = new Users();
        user1.Name = "Lisa";
        user1.Surname = "Doe";
        user1.Age = 21;

        Users user2 = new Users();
        user2.Name = "Mila";
        user2.Surname = "Jey";
        user2.Age = 19;

        userList.Add(user1);
        userList.Add(user2); 

        foreach (var user in userList)
        {
            Console.WriteLine("User Name:" + user.Name);
            Console.WriteLine("User Surname:" + user.Surname);
            Console.WriteLine("User Age: " + user.Age);
        }
        
    }
}
public class Users
{
    private string name;
    private string surname;
    private int age;

    public string Name { get => name; set => name = value;}
    public string Surname { get => surname; set => surname = value;}
    public int Age { get => age; set => age = value;}
}