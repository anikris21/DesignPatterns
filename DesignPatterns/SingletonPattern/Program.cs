using SingletonPattern;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
UserManager u1 = UserManager.Instance;

Console.WriteLine(u1.st);

Console.ReadKey();
