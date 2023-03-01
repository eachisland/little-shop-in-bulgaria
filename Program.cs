namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            string product = Console.ReadLine();
            int stuff = int.Parse(Console.ReadLine());
            if (town == "sofia")
            {
                if (product == "juce")
                { 
                    double jprice = 1.20;
                    Console.WriteLine(jprice * stuff);

                }
                else if (product == "water")
                {
                    double wprice = 0.8;
                    Console.WriteLine(wprice * stuff);

                }
                else if (product == "coffee")
                {
                    double cprice = 0.5;
                    Console.WriteLine(cprice * stuff);

                }
                else if (product == "sweets")
                {
                    double sprice = 1.45;
                    Console.WriteLine(sprice * stuff);

                }
                else if (product == "peanuts")
                {
                    double pprice = 1.60;
                    Console.WriteLine(pprice * stuff);

                }
                if (town == "plovdiv")
                {
                    if (product == "juce")
                    {
                        double jprice = 1.15;
                        Console.WriteLine(jprice * stuff);

                    }
                    else if (product == "water")
                    {
                        double wprice = 0.70;
                        Console.WriteLine(wprice * stuff);

                    }
                    else if (product == "coffee")
                    {
                        double cprice = 0.40;
                        Console.WriteLine(cprice * stuff);

                    }
                    else if (product == "sweets")
                    {
                        double sprice = 1.30;
                        Console.WriteLine(sprice * stuff);

                    }
                    else if (product == "peanuts")
                    {
                        double pprice = 1.50;
                        Console.WriteLine(pprice * stuff);

                    }
                    if (town == "varna")
                    {
                        if (product == "juce")
                        {
                            double jprice = 1.10;
                            Console.WriteLine(jprice * stuff);

                        }
                        else if (product == "water")
                        {
                            double wprice = 0.70;
                            Console.WriteLine(wprice * stuff);

                        }
                        else if (product == "coffee")
                        {
                            double cprice = 0.45;
                            Console.WriteLine(cprice * stuff);

                        }
                        else if (product == "sweets")
                        {
                            double sprice = 1.10;
                            Console.WriteLine(sprice * stuff);

                        }
                        else if (product == "peanuts")
                        {
                            double pprice = 1.55;
                            Console.WriteLine(pprice * stuff);

                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
       