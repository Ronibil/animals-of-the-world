using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Animal a = new Animal();
            ZOO zoo = new ZOO(a.animals);
            int choise = 0;
            while (choise != 7)
            {
                try
                {
                    PrintMenu();
                    choise = int.Parse(Console.ReadLine());
                    switch (choise)
                    {
                        case 1:
                            Console.WriteLine("Please choose option to show all animals in:\n1.\tRegular Array\n2.\tArray List\n3.\tHash Table");
                            Console.Write("Selection: ");
                            int choise2 = int.Parse(Console.ReadLine());
                            switch (choise2)
                            {
                                case 1:
                                    a.Print();
                                    break;
                                case 2:
                                    a.PrintArraylist();
                                    break;
                                case 3:
                                    a.PrintHash();
                                    break;
                                default:
                                    Console.WriteLine("Incorrect input");
                                    break;
                            }
                            break;
                        case 2:
                            Console.WriteLine("Please Choose Continent to see the list of animals from this continent: \n1.\tAFRICA\n2.\tNORTH AMERICA\n3.\tSOUTH AMERICA\n4.\tANTARCTIC\n5.\tAUSTRALIA\n6.\tEURASIA");
                            Console.Write("Selection");
                            int conti = int.Parse(Console.ReadLine());
                            switch (conti)
                            {
                                case 1:
                                    foreach (var item in zoo["AFRICA"])
                                    {
                                        Console.WriteLine(item);
                                    }
                                    break;
                                case 2:
                                    foreach (var item in zoo["NORTH AMERICA"])
                                    {
                                        Console.WriteLine(item);
                                    }
                                    break;
                                case 3:
                                    foreach (var item in zoo["SOUTH AMERICA"])
                                    {
                                        Console.WriteLine(item);
                                    }
                                    break;
                                case 4:
                                    foreach (var item in zoo["ANTARCTIC"])
                                    {
                                        Console.WriteLine(item);
                                    }
                                    break;
                                case 5:
                                    foreach (var item in zoo["AUSTRALIA"])
                                    {
                                        Console.WriteLine(item);
                                    }
                                    break;
                                case 6:
                                    foreach (var item in zoo["EURASIA"])
                                    {
                                        Console.WriteLine(item);
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Wrong input, try again");
                                    break;
                            }
                            break;
                        case 3:
                            Application.EnableVisualStyles();
                            Application.SetCompatibleTextRenderingDefault(false);
                            Application.Run(new open_menu());
                            break;
                        case 4:
                            Console.Write("Would you want to sort by:\n1.\tName\n2.\tWeight\n");
                            Console.Write("Selection: ");
                            int sortingOpt = int.Parse(Console.ReadLine());
                            switch (sortingOpt)
                            {
                                case 1:
                                    a.sort("Name");
                                    break;
                                case 2:
                                    a.sort("Weight");
                                    break;
                                default:
                                    Console.WriteLine("Incorrect input");
                                    break;
                            }
                            break;
                        case 5:
                            VegetarianAnimals v = new VegetarianAnimals();
                            foreach (var item in v.CreateVegArray())
                            {
                                Console.WriteLine(item);
                            }
                            break;
                        case 6:
                            Console.WriteLine($"Please select random ID between 0 and {a.animals.Length}: ");
                            Console.Write("Selection: ");
                            int choiseID = int.Parse(Console.ReadLine());
                            foreach (var item in zoo[choiseID])
                            {
                                Console.WriteLine(item);
                            }
                            break;
                        case 7:
                            Console.WriteLine("Bye Bye..");
                            break;
                        default:
                            Console.WriteLine("Incorrect input");
                            break;
                    }
                    Console.WriteLine("press any key to back to the menu ...");
                    Console.ReadKey();
                    Console.Clear();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        private static void PrintMenu()
        {
            Console.WriteLine("1.\tShow all animals\n2.\tShow animals from one continent\n3.\tRun windows form\n4.\tOrder animals by Name or Weight\n5.\tShow only vegetarian animals\n6.\tSearch animal by ID\n7.\tExit");
            Console.Write("Selection: ");
        }
    }
}
