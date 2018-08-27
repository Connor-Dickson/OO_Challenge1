using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge01
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int menunum = 0;


            while (menunum != 5)
            {
                Console.WriteLine("Hello, Welcome to the Shape Creation Menu");
                Console.WriteLine("Press the appropriate number and press enter to continue");
                Console.WriteLine("1. Create Square.");
                Console.WriteLine("2. Create Rectangle.");
                Console.WriteLine("3. Create Equilateral Triangle.");
                Console.WriteLine("4. Create Right Angle Triangle.");
                Console.WriteLine("5. Exit.");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Square Creation.");
                        Console.WriteLine("Enter Colour.");
                        string sqcolour = Console.ReadLine();

                        int sqside;

                        Console.WriteLine("Enter Side Length.");
                        try
                        {
                            sqside = int.Parse(Console.ReadLine());
                            if(sqside <= 0)
                            {
                                throw new LengthException();
                            }

                        }
                        catch (FormatException fex)
                        {
                            Console.WriteLine(fex.Message);
                            break;
                        }

                        catch (LengthException lex)
                        {
                            Console.WriteLine(lex.Message);
                            break;
                        }

                        Square square = new Square(sqcolour, sqside);
                        Console.WriteLine(square.GetInfo());
                        break;

                    case 2:
                        Console.WriteLine("Rectangle Creation");
                        Console.WriteLine("Enter Colour.");
                        string reccolour = Console.ReadLine();

                        int recside1;
                        int recside2;
                        Console.WriteLine("Enter First Side Length.");
                        try
                        {
                            recside1 = int.Parse(Console.ReadLine());
                            if (recside1 <= 0)
                            {
                                throw new LengthException();
                            }
                        }
                        catch (FormatException fex)
                        {
                            Console.WriteLine(fex.Message);
                            break;
                        }
                        catch (LengthException lex)
                        {
                            Console.WriteLine(lex.Message);
                            break;
                        }

                        Console.WriteLine("Enter Second Side Length.");
                        try
                        {
                            recside2 = int.Parse(Console.ReadLine());
                            if (recside2 <= 0)
                            {
                                throw new LengthException();
                            }
                        }
                        catch (FormatException fex)
                        {
                            Console.WriteLine(fex.Message);
                            break;
                        }
                        catch (LengthException lex)
                        {
                            Console.WriteLine(lex.Message);
                            break;
                        }

                        Rectangle rectangle = new Rectangle(reccolour, recside1, recside2);
                        Console.WriteLine(rectangle.GetInfo());
                        break;
                    case 3:
                        Console.WriteLine("Equilateral Triangle Creation.");
                        Console.WriteLine("Enter Colour.");
                        string eqtcolour = Console.ReadLine();

                        int eqtside;

                        Console.WriteLine("Enter Side Length.");
                        try
                        {
                            eqtside = int.Parse(Console.ReadLine());
                            if (eqtside <= 0)
                            {
                                throw new LengthException();
                            }

                        }
                        catch (FormatException fex)
                        {
                            Console.WriteLine(fex.Message);
                            break;
                        }

                        catch (LengthException lex)
                        {
                            Console.WriteLine(lex.Message);
                            break;
                        }
                        EquilateralTriangle eqTriangle = new EquilateralTriangle(eqtcolour, eqtside);
                        Console.WriteLine(eqTriangle.GetInfo());
                        break;
                    case 4:
                        Console.WriteLine("Right Angle Triangle Creation");
                        Console.WriteLine("Enter Colour.");
                        string ratcolour = Console.ReadLine();

                        int ratside1;
                        int ratside2;
                        Console.WriteLine("Enter First Side Length.");
                        try
                        {
                            ratside1 = int.Parse(Console.ReadLine());
                            if (ratside1 <= 0)
                            {
                                throw new LengthException();
                            }
                        }
                        catch (FormatException fex)
                        {
                            Console.WriteLine(fex.Message);
                            break;
                        }
                        catch (LengthException lex)
                        {
                            Console.WriteLine(lex.Message);
                            break;
                        }

                        Console.WriteLine("Enter Second Side Length.");
                        try
                        {
                            ratside2 = int.Parse(Console.ReadLine());
                            if (ratside2 <= 0)
                            {
                                throw new LengthException();
                            }
                        }
                        catch (FormatException fex)
                        {
                            Console.WriteLine(fex.Message);
                            break;
                        }
                        catch (LengthException lex)
                        {
                            Console.WriteLine(lex.Message);
                            break;
                        }

                        RightAngleTriangle rat = new RightAngleTriangle(ratcolour, ratside1, ratside2);
                        Console.WriteLine(rat.GetInfo());
                        break;
                    case 5:
                        Console.WriteLine("Goodbye");
                        menunum = 5;
                        break;
                }
            }
        }
    }
}
