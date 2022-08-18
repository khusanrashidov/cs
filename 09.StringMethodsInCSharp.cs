using System;
namespace StringMethodsInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Khusan Rashidov";
            fullName = fullName.ToUpper();
            Console.WriteLine(fullName);
            fullName = fullName.ToLower();
            Console.WriteLine(fullName);
            string phoneNumber = "+99801-234-56-78";
            //replace method replaces particular char or string to another char or string respectively
            phoneNumber = phoneNumber.Replace('-', ' '); //with single quotes for (char, char)
            phoneNumber = phoneNumber.Replace("+", ""); //with double quotes for (string, string)
            Console.WriteLine("The phone number: " + phoneNumber);
            string country = phoneNumber.Remove(3); //remove method removes everything after set index number in brackets
            Console.WriteLine("The country code: {0}", country);
            fullName = fullName.Replace(" ", "");
            string username = fullName.Insert(0, "@");
            Console.WriteLine("Username: " + username);
            string name = "Kim";
            name = name.Insert(0, "Ms. ");
            name = name.Insert(7, " Jisoo");
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine(name.Length);
            string FullName = "Khusan Botirovich Rashidov";
            Console.WriteLine("Full name: " + FullName);
            string FirstName = FullName.Substring(0, 6);
            string MiddleName = FullName.Substring(7, 11);
            string LastName = FullName.Substring(18, 8);
            Console.WriteLine("First name: {0}\nMiddle name: {1}\nLast name: {2}", FirstName, MiddleName, LastName);
            //do not confuse char/Char and string/String
            char nickname = 'K';
            Console.WriteLine(Char.ToLower(nickname));
            String patronymic = "k";
            Console.WriteLine(patronymic.ToUpper());
            Console.ReadKey();
        }
    }
}