//
class Program {
    static void Main_Menu()
    {
    Console.WriteLine("=================");
    Console.WriteLine("   Etreal Calc"   );
    Console.WriteLine("=================");
    Math_Calc();
    static void Math_Calc()
    {   String value;
        Console.WriteLine("   Etreal Math Calculator");
        Console.WriteLine("============================");
        do {
            int res;
            Console.WriteLine("enter your number");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter the operator symbol (+,-,*,/) : ");
            string? OPSym = Console.ReadLine();

            Console.WriteLine("enter your second number");
            int Num2 = Convert.ToInt32(Console.ReadLine());

            switch (OPSym)
            {
                case "+" :
                    res = Num1 + Num2;
                    Console.WriteLine($"{Num1} + {Num2} = {res}");
                    break;
                case "-" :
                    res = Num1 - Num2;
                    Console.WriteLine($"{Num1} - {Num2} = {res}");
                    break;    
                case "*" :
                    res = Num1 * Num2;
                    Console.WriteLine($"{Num1} * {Num2} = {res}");
                    break;
                case "/" :
                    if (Num2 != 0) 
                        {
                        res = Num1 / Num2;
                        Console.WriteLine($"{Num1} / {Num2} = {res}");
                        }
                    else 
                        {
                        Console.WriteLine("cannot divide by zero");
                        return;
                        }
                    break;
                default:
                    Console.WriteLine("Wrong input!");
                    break;
            }
            Console.ReadLine();
            Console.Write("Do you want to continue? (y/n) : ");
            value = Console.ReadLine();
        }
        while (value == "y" || value == "Y");
        if (value == "n" || value == "N")
        {Main_Menu();}
    }   
    }
}