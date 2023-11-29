namespace conditions_task_no_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C. Task no 4");
            //Napisz program, który sprawdzi czy podany przez użytkownika rok jest rokiem przestępnym.
            //Dane: 2016. Rezultat w terminalu: 2016 jest rokiem przestepnym.

            Console.WriteLine("Podaj rok: ");
            string yearInput = Console.ReadLine();
            int year;
            if (int.TryParse(yearInput, out year))
            {
                Console.WriteLine("Podany rok to: ");

                if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))
                {
                    Console.WriteLine($"{year} jest rokiem przestępnym");
                }
                else
                {
                    Console.WriteLine($"{year} nie jest rokiem przestępnym");
                }
            }
            else
            {
                Console.WriteLine("Błąd. Wprowadź rok: ");
            }

        }
    }
}
