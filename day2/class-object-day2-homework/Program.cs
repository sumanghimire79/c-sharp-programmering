using class_object_day2_homework;
using System.Runtime.InteropServices;

Console.WriteLine("counter");
Counter counter = new Counter();

// clicking the counter 
Console.WriteLine(counter.Click());
Console.WriteLine(counter.Click());
Console.WriteLine(counter.Click());

int currentValue= counter.Click();
Console.WriteLine($" counter value now is : {currentValue}");
Console.WriteLine(Environment.NewLine);
//reset the counter
Console.WriteLine(counter.Reset());

// Click the counter again
currentValue = counter.Click();
Console.WriteLine($"The counter value is now: {currentValue}");
Console.WriteLine(Environment.NewLine);

// instance of Die 
Die d = new Die();

// rolling the die 
Console.WriteLine($" the random side is {d.Roll()}");
Console.WriteLine($" the random side2 is {d.Roll()}");
Console.WriteLine(Environment.NewLine);
Console.WriteLine($" the RollNsided side is {d.RollNSide(3)}");
Console.WriteLine($" the RollNsided side2 is {d.RollNSide(122)}");
Console.WriteLine(Environment.NewLine);

Console.WriteLine("Students");
Student s = new Student("suman");
Console.WriteLine(s.Name);
Console.WriteLine($" the score is {s.AddTest(50)}");
Console.WriteLine($" the score is {s.AddTest(15)}");
Console.WriteLine($" the score is {s.AddTest(25)}");
Console.WriteLine($" the score is {s.AddTest(30)}");
Console.WriteLine($"Total score: {s.GetTotalScore()}");
Console.WriteLine($"Average score: {s.GetAverageScore()}");
Console.WriteLine($"Test information for {s.Name}. Total score: {s.GetTotalScore()} - Average score: {s.GetAverageScore()}");
Console.WriteLine(Environment.NewLine);

BankAccount b = new BankAccount("suman","123454324",100);
Console.WriteLine(b.GetBalance());
Console.WriteLine(b.GetAccountInfo());
b.Deposit(10.00);
b.Deposit(10.00);
b.Withdraw(20.00);
Console.WriteLine(b.GetBalance());
b.Deposit(10.00);
b.Deposit(10.00);
Console.WriteLine(b.GetBalance());
b.Withdraw(40.00);
b.Deposit(0.00);

Console.WriteLine(Console.ReadKey());