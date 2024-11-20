var _Date = DateTime.Now;


Console.WriteLine("What's your name?");
var _name = Console.ReadLine();

Console.WriteLine($"Where do you live, {_name} ?");
var _home = Console.ReadLine();

Console.WriteLine($"What's your dream, {_name}?");
var _dream = Console.ReadLine();

Console.WriteLine($"Do you have a favourite color? {_name}.");
var _color = Console.ReadLine();

Console.WriteLine($"Right now, on {_Date}, You have entered your data.");
Console.WriteLine($"Here's what you have told us: {Environment.NewLine}Your Name : {_name}. {Environment.NewLine}You Live in : {_home}. {Environment.NewLine}Your Dream is to Become a(n) : {_dream}. {Environment.NewLine}Your Favourite Color is : {_color}.");

