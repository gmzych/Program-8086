using System;
using System.Collections.Generic;

namespace ProjectC

{
    class Program
    {
        static void Main(string[] args)
        {


            var register = new Dictionary<string, int>();



            Console.Write("Prosze wprowadzic wartosc rejestru AX: ");
            string boxAX = Console.ReadLine();

            int axInt;

            if (!string.IsNullOrEmpty(boxAX) && int.TryParse(boxAX, out axInt))
            {
                register.Add("AX", axInt);

            }

            Console.Write("Prosze wprowadzic wartosc rejestru BX: ");
            string boxBX = Console.ReadLine();

            int bxInt;

            if (!string.IsNullOrEmpty(boxBX) && int.TryParse(boxBX, out bxInt))
            {
                register.Add("BX", bxInt);

            }

            Console.Write("Prosze wprowadzic wartosc rejestru CX: ");
            string boxCX = Console.ReadLine();

            int cxInt;

            if (!string.IsNullOrEmpty(boxCX) && int.TryParse(boxCX, out cxInt))
            {
                register.Add("CX", cxInt);
            }

            Console.Write("Prosze wprowadzic wartosc rejestru DX: ");
            string boxDX = Console.ReadLine();

            int dxInt;

            if (!string.IsNullOrEmpty(boxDX) && int.TryParse(boxDX, out dxInt))
            {
                register.Add("DX", dxInt);
            }

            Console.WriteLine();
            Console.WriteLine($"Twoje wartosci to: ");

            Console.WriteLine();
            Console.WriteLine($"1.AX: {register["AX"]}");
            Console.WriteLine($"1.BX: {register["BX"]}");
            Console.WriteLine($"1.CX: {register["CX"]}");
            Console.WriteLine($"1.DX: {register["DX"]}");
            Console.WriteLine();
            Console.WriteLine("Wybierz swoje 2 rejestry na ktorych chcesz wykonac rozkaz mov");
            Console.WriteLine("AX, BX, CX, DX");

            int zmienna;

            do
            {
                string register1 = Console.ReadLine().ToLower();


                switch (register1)
                {
                    case "ax":
                        Console.WriteLine("Wybrales wartosc AX");
                        break;
                    case "bx":
                        Console.WriteLine("Wybrales wartosc BX");
                        break;
                    case "cx":
                        Console.WriteLine("Wybrales wartosc CX");
                        break;
                    case "dx":
                        Console.WriteLine("Wybrales wartosc DX");
                        break;
                    default:
                        Console.WriteLine("Nie rozumiem prosze wybrac jeszcze raz");
                        continue;
                        break;
                }

                zmienna = register[register1.ToUpper()];
                break;
            }
            while (true);

            do
            {
                string register2 = Console.ReadLine().ToLower();


                switch (register2)
                {
                    case "ax":
                        Console.WriteLine("Wybrales wartosc AX");
                        break;
                    case "bx":
                        Console.WriteLine("Wybrales wartosc BX");
                        break;
                    case "cx":
                        Console.WriteLine("Wybrales wartosc CX");
                        break;
                    case "dx":
                        Console.WriteLine("Wybrales wartosc DX");
                        break;
                    default:
                        Console.WriteLine("Nie rozumiem prosze wybrac jeszcze raz");
                        continue;
                        break;

                }



                register[register2.ToUpper()] = zmienna;
                break;
            }
            while (true);

            Console.WriteLine();
            Console.WriteLine($"1.AX: {register["AX"]}");
            Console.WriteLine($"1.BX: {register["BX"]}");
            Console.WriteLine($"1.CX: {register["CX"]}");
            Console.WriteLine($"1.DX: {register["DX"]}");






        }





    }
}
