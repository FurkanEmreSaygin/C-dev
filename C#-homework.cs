using System;
using System.Data;
using System.Reflection;

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
        
        /*
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
        */

        //------------------- String İşlemleri Uygulaması -------------------- //


        /*
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        char last_char = sentence[sentence.Length - 1];

        Console.WriteLine($"Uppercase: {sentence.ToUpper()}");
        Console.WriteLine($"Lowercase: {sentence.ToLower()}");
        Console.WriteLine($"Character count: {sentence.Length}");
        Console.WriteLine($"First character: {sentence.Substring(0,1)}");
        Console.WriteLine($"Last character: {last_char}");
        Console.WriteLine($"Trimmed sentence: {sentence.Trim()}");
        */

        //----------------------- Yaş Hesaplama ------------------------------// 
        /*
        Console.Write("Enter your birth year: ");
        int BirthDay = Convert.ToInt32(Console.ReadLine());

        int SuAn = DateTime.Now.Year;

        int age = SuAn - BirthDay;

        Console.WriteLine($"You were born in {BirthDay} and you are {age} years old.");
        */

        //-----------------------  Basit Rastgele Sayı Üretme Uygulaması -------------------//

        /*
        Random rasgelesayi = new Random();
        int Sayi = rasgelesayi.Next(1,101);
        
        Console.WriteLine($"Generated random number: {Sayi}");
        */
        
        //-----------------------  Ortalama Hesaplama -------------------//
        
        Console.Write("Enter first number: ");
        int first = Convert.ToInt32(Console.ReadLine());
       
        Console.Write("Enter second number: ");
        int second = Convert.ToInt32(Console.ReadLine());
    
        Console.Write("Enter third number: ");
        int third = Convert.ToInt32(Console.ReadLine());

        int average = (first + second + third) / 3;
        Console.WriteLine($"Average: {average}");
    }
}