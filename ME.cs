Console.WriteLine("What's your name?");
var name = Console.ReadLine();

Console.WriteLine($"{Environment.NewLine}Hello, {name}.{Environment.NewLine}What's your favorite color?");
var color = Console.ReadLine();
var Date = DateTime.Now;

Console.WriteLine($"{Environment.NewLine}On {Date:d}. You, {name} have interacted with M.E. {Environment.NewLine} And also, you told me your favourite color, which is {color}.");

Console.WriteLine($"{Environment.NewLine} Press any key to exit....");
Console.ReadKey(true);