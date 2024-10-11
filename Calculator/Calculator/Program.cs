using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2024-2025.
 * Extended by students.
 */

namespace Calculator
{
    internal class Program
    {
        private static string reverse(string wantToReverse)
        {
            char[] charArray = wantToReverse.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        static void Main(string[] args)
        {

            /*
             * ZADANI
             * Vytvor program ktery bude fungovat jako kalkulacka. Kroky programu budou nasledujici:
             * 1) Nacte vstup pro prvni cislo od uzivatele (vyuzijte metodu Console.ReadLine() - https://learn.microsoft.com/en-us/dotnet/api/system.console.readline?view=netframework-4.8.
             * 2) Zkonvertuje vstup od uzivatele ze stringu do integeru - https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number.
             * 3) Nacte vstup pro druhe cislo od uzivatele a zkonvertuje ho do integeru. (zopakovani kroku 1 a 2 pro druhe cislo)
             * 4) Nacte vstup pro ciselnou operaci. Rozmysli si, jak operace nazves. Muze to byt "soucet", "rozdil" atd. nebo napr "+", "-", nebo jakkoliv jinak.
             * 5) Nadefinuj integerovou promennou result a prirad ji prozatimne hodnotu 0.
             * 6) Vytvor podminky (if statement), podle kterych urcis, co se bude s cisly dit podle zadane operace
             *    a proved danou operaci - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements.
             * 7) Vypis promennou result do konzole
             * 
             * Rozsireni programu pro rychliky / na doma (na poradi nezalezi):
             * 1) Vypis do konzole pred nactenim kazdeho uzivatelova vstupu co po nem chces (aby vedel, co ma zadat)
             * 2) a) Kontroluj, ze uzivatel do vstupu zadal, co mel (cisla, popr. ciselnou operaci). Pokud zadal neco jineho, napis mu, co ma priste zadat a program ukoncete.
             * 2) b) To same, co a) ale misto ukonceni programu opakovane cti vstup, dokud uzivatel nezada to, co ma
             *       - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-while-statement
             * 3) Umozni uzivateli zadavat i desetinna cisla, tedy prekopej kalkulacku tak, aby umela pracovat s floaty
             */
            string value = "y";
            float systemBaseNumber = 0;
            do
            {
                bool decimalSystemYes = true;
                Console.WriteLine("chceš počítat v jiné než desítkové soustavě než desítkové?(y/n)");
                if (Console.ReadLine().ToLower() == "y")
                {

                    Console.WriteLine("Enter the base of the number system you want to work with (2; 3; 4; ...). If no number is entered, the problem will automatically be in the decimal system.");
                    if (float.TryParse(Console.ReadLine(), out systemBaseNumber))
                        decimalSystemYes = false;

                }


                Console.WriteLine("Write a problem. After each separate input, go to a new line. To end the example, write =. If you have chosen a number system other than decimal, write the numbers in the chosen system.");
                

                // Lists to hold numbers and operators
                List<double> numbers = new List<double>();
                List<string> operators = new List<string>();
                string input;
                // Parse numbers and operators
                
                
                    
                    if (decimalSystemYes)
                    {

                        do
                        {
                            input = Console.ReadLine();
                        Console.WriteLine(input);
                        if (double.TryParse(input, out double number))
                        {

                            numbers.Add(number);
                        }
                        else if (input == "=")
                            break;
                        else
                        {
                            operators.Add(input);
                        }
                            
                        } while (true);
                        


                       


                    }
                    else
                    {
                    do
                    {
                        input = Console.ReadLine();
                        if (int.TryParse(input, out int number))
                        {
                            double numberConverted = 0;
                            string numberStringValue = Convert.ToString(number);
                            
                            for (int x = 0; x < numberStringValue.Length; x++)
                            {
                                char numberPart = numberStringValue[x];
                                int numberPartInt = numberPart - '0';
                                Console.WriteLine(numberPartInt);
                                double numberPartConverted = numberPartInt;

                                numberPartConverted *= Math.Pow(systemBaseNumber, numberStringValue.Length-x-1);

                                Console.WriteLine(numberPartConverted);
                                numberConverted += numberPartConverted;
                            }

                            numbers.Add(numberConverted);


                        }
                        else if (input == "=")
                            break;
                        else
                        {
                            operators.Add(input);
                        }
                    } while (true); 


                    }

                
                
                for (int i = 0; i < numbers.Count; i++)
                {
                    Console.WriteLine(numbers[i]);
                }



                // Calculate the result based on the operators
                bool operationCheck = true;
                double result = numbers[0];
                if (operators.Count > 0)
                {
                    for (int i = 0; i < operators.Count; i++)
                    {
                        switch (operators[i])
                        {
                            case "+":
                                result += numbers[i + 1];
                                break;
                            case "-":
                                result -= numbers[i + 1];
                                break;
                            case "*":
                                result *= numbers[i + 1];
                                break;
                            case "/":
                                if (numbers[i + 1] != 0)
                                {
                                    result /= numbers[i + 1];
                                }
                                else
                                {
                                    Console.WriteLine("Error: Division by zero.");
                                    operationCheck = false;

                                }
                                break;
                            default:
                                {
                                    Console.WriteLine("Error: Invalid operator." + operators[i]);

                                    operationCheck = false;
                                    break;
                                }
                        }
                    }
                    // Output the result
                    if (operationCheck)
                    {
                        
                        if(decimalSystemYes)
                        {
                            Console.WriteLine("The result is: " + result);
                        }

                        else
                        {
                            Console.WriteLine("The result is: " + result);

                            double resultInSystem = result;
                            string resultSystemString = "";
                            do
                            {


                                Console.WriteLine("baf");
                                string resultHelp = Convert.ToString(result % systemBaseNumber);
                                Console.WriteLine(resultHelp + "zbytek");

                                resultSystemString = resultHelp + resultSystemString;
                                Console.WriteLine(resultSystemString + "dosavadní hodnota čísla");

                                resultInSystem -= Convert.ToInt32(resultHelp);
                                Console.WriteLine(resultInSystem + "číslo po odečtení zbytku");
                                resultInSystem /= systemBaseNumber;
                                Console.WriteLine(resultInSystem + "číslo po vydělení.");

                                
                            } while (resultInSystem>=systemBaseNumber);
                            reverse(resultSystemString);
                            if (Convert.ToInt32(resultSystemString) == 0)
                                Console.WriteLine("1" + resultSystemString);
                            else
                                Console.WriteLine(resultSystemString + "result in given numerical system");


                        }
                        
                        
                            

                    }

                }
                else
                    Console.WriteLine("no operators were given");

                Console.Write("Do you want to continue(y/n):");
                value = Console.ReadLine().ToLower();
            } while (value == "y");

            Console.ReadKey(); //Toto nech jako posledni radek, aby se program neukoncil ihned, ale cekal na stisk klavesy od uzivatele.


        }
    }
    
}


            

