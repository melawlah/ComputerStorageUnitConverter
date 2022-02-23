using System;

namespace ComputerStorageUnitConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompts user to enter an integer
            Console.WriteLine("Please enter an integer to be converted");
            var userInput = Console.ReadLine();

            var isInputAnInteger = isAnInteger(userInput, out int value);

            //checks if the user entered an integer
            while (!isInputAnInteger)
            {
                Console.WriteLine("Please enter an integer to be converted");
                userInput = Console.ReadLine();
                isInputAnInteger = isAnInteger(userInput, out value);
            }

            Console.WriteLine($"{Environment.NewLine} Choose your conversion:");
            Console.WriteLine("1. Megabytes to Bytes");
            Console.WriteLine("2. Gigabytes to Megabytes");
            Console.WriteLine("3. Terabytes to Gigabytes");
            Console.WriteLine("4. Exit");

            var optionSelected = Console.ReadLine();

            ByteConversion conversion = new ByteConversion(value);
            double convertedValue;

            switch (optionSelected)
            {
                case "1":
                    convertedValue = conversion.ConvertMegabytesToBytes();
                    Console.WriteLine(value + " MB is equal to " + convertedValue + " B");
                    Console.ReadLine();
                    break;
                case "2":
                    convertedValue = conversion.ConvertGigabytesToMegabyte();
                    Console.WriteLine(value + " GB is equal to " + convertedValue + " MB");
                    Console.ReadLine();
                    break;
                case "3":
                    convertedValue = conversion.ConvertTerabytetoGigabytes();
                    Console.WriteLine(value + " TB is equal to " + convertedValue + " GB");
                    Console.ReadLine();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    do
                    {
                        Console.WriteLine($"{Environment.NewLine} Choose your conversion:");
                        Console.WriteLine("1. Megabytes to Bytes");
                        Console.WriteLine("2. Gigabytes to Megabytes");
                        Console.WriteLine("3. Terabytes to Gigabytes");
                        Console.WriteLine("4. Exit");

                        optionSelected = Console.ReadLine();

                        switch (optionSelected)
                        {
                            case "1":
                                convertedValue = conversion.ConvertMegabytesToBytes();
                                Console.WriteLine(value + " MB is equal to " + convertedValue + " B");
                                Console.ReadLine();
                                break;
                            case "2":
                                convertedValue = conversion.ConvertGigabytesToMegabyte();
                                Console.WriteLine(value + " GB is equal to " + convertedValue + " MB");
                                Console.ReadLine();
                                break;
                            case "3":
                                convertedValue = conversion.ConvertTerabytetoGigabytes();
                                Console.WriteLine(value + " TB is equal to " + convertedValue + " GB");
                                Console.ReadLine();
                                break;
                            case "4":
                                Environment.Exit(0);
                                break;
                        }

                    }
                    while (optionSelected != "1" && optionSelected != "2" && optionSelected != "3" && optionSelected != "4" );
                    break;
            }
        }
        //converts the string the user entered to a number and passes the value
        private static bool isAnInteger(string input, out int value)
        {
            var isInputAnInteger = int.TryParse(input, out value);
            return isInputAnInteger;
        }
    }
}
