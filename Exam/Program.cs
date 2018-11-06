using System;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            var valores = new int[]{ 6, 12, 18, 42, 44, 55, 67, 94 };
            var loop = 0;
            var size = valores.Length;
            var medium = (int)size / 2;
            var initial = 0;

            for (var i = 0;i < valores.Length; i++)
            {
                Console.WriteLine(loop++);
                if (valores[medium] > 67)
                {
                    //Lado izquierdo
                    size = medium;
                    medium = (int) size / 2;
                }
                else if(valores[medium] < 67)
                { //Lado derecho
                    initial = medium;
                    medium = ((size - initial) / 2) + initial;
                    i = initial;
                }
                else if (valores[i] == 67)
                {
                        Console.WriteLine("Valor {0},Encontrado en loop {0} posicion {0}", valores[i], loop, i);
                        break;
                }
            }
            Console.Read();
            
        }
    }
}
