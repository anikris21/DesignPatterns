// See https://aka.ms/new-console-template for more information
using PrototypePattern;

Console.WriteLine("Hello, World!");

User user = new User("Avin", "Blore");
user.Age = 30;

User u1 = user.Clone() as User;
Console.WriteLine(u1.ToString());
