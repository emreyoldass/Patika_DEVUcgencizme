using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patika_DEVücgencizme
{
    internal class ücgenler
    {
        public void dikücgen(int say)
        {
            //dik üçgen (90°- 45° - 45°)
            for (int i = 0; i < say; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();            
            }
        }
        public void tersdikücgen(int say)
        {
            for (int i = 0; i < say; i++)
            {
                for (int j = i; j < say-1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
        public void ücgen(int say)
        {
            //Düz üçgen (60°- 60° - 60°) 
            for (int i = 0; i < say; i++)
            {
                for (int j = i; j < say; j++)
                {
                    Console.Write(" ");

                }
                for (int x = 0; x < i; x++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        public void birlestirilmisücgen(int say)
        {
            for (int i = 0; i < say; i++)
            {
                
                for (int a = i; a < say; a++)
                {
                    Console.Write(" ");
                   
                  
                }
                for (int x = 0; x < i; x++)
                {
                    Console.Write("*");
                    Console.Write("");
                }
                for (int t = 0; t < say; t++)
                {
                    Console.Write("");
                }
                for (int q = 0; q < i; q++)
                {
                    Console.Write("");
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }


    }
}

