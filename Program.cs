using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet2_7_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj...napisz ile masz lat");
            int wiek = Int32.Parse(Console.ReadLine());

            if (wiek < 21)

            {
                Console.WriteLine("Niestety nie mozesz ubiegać sie o stanowisko w rządzie RP");
            }
            else if (wiek > 21 && wiek < 30)
            {
                Console.WriteLine("Gratulacje mozesz zostac posłem lub premierem");

            }
            else if (wiek > 30 && wiek < 35)

            {

                Console.WriteLine("Gratulacjie możesz zostać senatorem, posłem i premierem");

            }
            else 
              { 
              
                Console.WriteLine("Gratulacje możesz zostać posłem senatorem premierem przezydentem i czym tam jeszcze chcesz");

              }

            Console.ReadLine();


                                                                    

        }
    }
}

