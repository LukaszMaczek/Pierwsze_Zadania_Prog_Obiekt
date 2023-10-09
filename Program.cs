namespace Pierwsze
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PoleKola();
            //Prostokat();
            //Parzysta();
            //MaxLiczba();
            //RownanieKwadratowe();
            //ZmianaWaluty(); jeszcze nie działa
        }
        static void PoleKola()
        {
            Console.WriteLine("Podaj promien kola: ");
            double r = Double.Parse(Console.ReadLine());
            if (r >= 0)
            {
                double pole = Math.PI * r * r;
                Console.WriteLine("Pole kola o promieniu {0} wynosi {1:f2}", r, pole);
            }
            else
            {
                Console.Write("Niepoprawne dane");
            }
        }
        static void Prostokat()
        {
            Console.WriteLine("Podaj pierwszy bok prostokata: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugi bok prostokata: ");
            int b = int.Parse(Console.ReadLine());
            if(a > 0 && b > 0)
            {
                int pole = a * b;
                if(a == b)
                {
                    Console.WriteLine("Ten prostokat jest kwadratem i jego pole wynosi {0}", pole);
                    return;
                }
                Console.WriteLine("Pole tego prostokata wynosi {0}", pole);
            }
            else
            {
                Console.WriteLine("Niepoprawne dane");
            }
        }
        static void Parzysta()
        {
            Console.WriteLine("Podaj liczbe calkowita: ");
            int p = int.Parse(Console.ReadLine());
            if(p % 2 == 0)
            {
                Console.WriteLine("Liczba {0} jest parzysta", p);
            }
            else
            {
                Console.WriteLine("Liczba {0} jest nieparzysta", p);
            }
        }
        static void MaxLiczba()
        {
            Console.WriteLine("Podaj pierwsza liczbe");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj druga liczbe");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj trzecia liczbe");
            int c = int.Parse(Console.ReadLine());
            int max = a;
            if(b > max)
            {
                max = b;
            }
            if(c > max)
            {
                max = c;
            }
            Console.WriteLine("Maksymalna z trzech podanych liczb to {0}", max);
        }
        static void RownanieKwadratowe()
        {
            Console.WriteLine("Podaj liczbe a w rownaniu kwadratowym ax^2+bx+c=0: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbe b w rownaniu kwadratowym ax^2+bx+c=0: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbe c w rownaniu kwadratowym ax^2+bx+c=0: ");
            double c = double.Parse(Console.ReadLine());
            double delta = b * b - 4 * a * c;
            if(delta > 0)
            {
                double x1 = ((-b) - Math.Sqrt(delta))/2;
                double x2 = ((-b) + Math.Sqrt(delta))/2;
                Console.WriteLine("Rozwiazaniami tego rownania sa x1={0:f2}, x2={1:f2}", x1, x2);
            }
            if(delta == 0)
            {
                double x = (-b) / 2;
                Console.WriteLine("Rozwiazaniem tego rownania jest x={0:f2}", x);
            }
            if(delta < 0)
            {
                double delta1 = -delta;
                double x3 = (-b) / 2;
                double xz3 = (-Math.Sqrt(delta1)) / 2;
                double x4 = (-b) / 2;
                double xz4 = (Math.Sqrt(delta1)) / 2;
                Console.WriteLine("Rozwiazaniami zespolonymi tego rownania sa x1={0:f2}{1:f2}i, x2={2:f2}+{3:f2}i", x3, xz3, x4, xz4);
            }
        }
        /*static void ZmianaWaluty()
        {
            Console.WriteLine("Podaj kwote w zl: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Na jaka walute chcesz zamienic ta kwote (wpisz '1', jesli na euro, '2' jesli na dolary lub '3' jesli na korony czeskie): ");
            int b = int.Parse(Console.ReadLine());
            switch (b)
            {
                case 1:
                    double euro = a / (4.56);
                    Console.WriteLine("Kwota {0:f) w zl to {1:f2} euro", a, euro);
                    break;
                case 2:
                    double dolar = a / 4.32;
                    Console.WriteLine("Kwota {0:f) w zl to {1:f2} dolarow", a, dolar);
                    break;
                case 3:
                    double korona = a * 5.36;
                    Console.WriteLine("Kwota {0:f) w zl to {1:f2} koron czeskich", a, korona);
                    break;
                default:
                    Console.WriteLine("Wybrales walute spoza mozliwych do wyboru");
                    break;
            }
        }*/
    }
}