using StatePattern;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Car car = new Car();
Console.WriteLine($"state = ${car.CurrentState}");
car.TakeAction(Car.Action.Start);
Console.WriteLine($"state = ${car.CurrentState}");
car.TakeAction(Car.Action.Accelarate);
Console.WriteLine($"state = ${car.CurrentState}");
