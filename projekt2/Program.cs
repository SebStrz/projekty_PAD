using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("=== Prosty Kalkulator ===");

        Console.Write("Podaj pierwszą liczbę: ");
        double liczba1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj operator (+, -, *, /): ");
        char operacja = Convert.ToChar(Console.ReadLine());

        Console.Write("Podaj drugą liczbę: ");
        double liczba2 = Convert.ToDouble(Console.ReadLine());

        double wynik;

        switch (operacja)
        {
            case '+':
                wynik = liczba1 + liczba2;
                break;
            case '-':
                wynik = liczba1 - liczba2;
                break;
            case '*':
                wynik = liczba1 * liczba2;
                break;
            case '/':
                if (liczba2 != 0)
                    wynik = liczba1 / liczba2;
                else
                {
                    Console.WriteLine("Błąd: Dzielenie przez zero!");
                    return;
                }
                break;
            default:
                Console.WriteLine("Nieznany operator.");
                return;
        }

        Console.WriteLine($"Wynik: {wynik}");
    }
  }
}