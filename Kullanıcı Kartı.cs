using System;

class Program{
    static void Main(){
        
        //---------------------- Kullanıcı Kartı -------------------//


        /*
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        
        Console.Write("Enter your surname: ");
        string surname = Console.ReadLine();

        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());
       
        Console.Write("Enter your city: ");
        string city = Console.ReadLine();
       
        Console.Write("Enter your profession: ");
        string profession = Console.ReadLine();

        Console.WriteLine("----------------------------");
        
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Surname: {surname}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"City: {city}");
        Console.WriteLine($"Profession: {profession}");

        Console.Write("----------------------------");
        */

        //----------------------------- Hesap Makinesi ------------------------ //

        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        if (b != 0){
            Console.WriteLine($"Addition: {a+b}");
            Console.WriteLine($"Subtraction: {a-b}");
            Console.WriteLine($"Multiplication: {a*b}");
            Console.WriteLine($"Division: {a/b}");
        }
        else{
            Console.Write("Error: Division by zero is not allowed.");
        }

    }
}