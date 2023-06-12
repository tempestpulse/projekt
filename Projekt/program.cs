using System;

namespace Projekt
{
    class Program
    {
        static void Main(string[] args)
            {
                List<Samolot> samoloty = new List<Samolot>();
                List<Lot> loty = new List<Lot>();
                List<Trasa> trasy = new List<Trasa>();
                List<Bilet> bilety = new List<Bilet>();
        
                LiniaLotnicza liniaLotnicza = new LiniaLotnicza("Nazwa linii", samoloty, loty, trasy, bilety);
                InterfejsUzytkownika interfejs = new InterfejsUzytkownika(liniaLotnicza);
                interfejs.Uruchom();
            }
    }

    class InterfejsUzytkownika
    {
        private LiniaLotnicza liniaLotnicza;

        public InterfejsUzytkownika(LiniaLotnicza liniaLotnicza)
        {
            this.liniaLotnicza = liniaLotnicza;
        }

        public void Uruchom()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("========== MENU GŁÓWNE ==========");
                Console.WriteLine("1. Dodaj samolot");
                Console.WriteLine("2. Usuń samolot");
                Console.WriteLine("3. Dodaj trasę");
                Console.WriteLine("4. Usuń trasę");
                Console.WriteLine("5. Wyświetl wszystkie samoloty");
                Console.WriteLine("6. Wyświetl wszystkie trasy");
                Console.WriteLine("7. Wyjście");
                Console.WriteLine("=================================");

                Console.Write("Wybierz opcję: ");
                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        DodajSamolot();
                        break;
                    case "2":
                        UsunSamolot();
                        break;
                    case "3":
                        DodajTrase();
                        break;
                    case "4":
                        UsunTrase();
                        break;
                    case "5":
                        WyswietlSamoloty();
                        break;
                    case "6":
                        WyswietlTrasy();
                        break;
                    case "7":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Nieprawidłowa opcja. Spróbuj ponownie.");
                        break;
                }

                Console.WriteLine();
            }
        }

        private void DodajSamolot()
        {
            Console.WriteLine("== DODAWANIE SAMOLOTU ==");
            Console.Write("Podaj zasięg samolotu: ");
            int zasiegSamolotu = int.Parse(Console.ReadLine());

            Console.Write("Podaj ID samolotu: ");
            string idSamolotu = Console.ReadLine();

            Console.Write("Podaj liczbę miejsc samolotu: ");
            int liczbaMiejscSamolotu = int.Parse(Console.ReadLine());

            Samolot samolot = new Samolot(zasiegSamolotu, idSamolotu, liczbaMiejscSamolotu);
            liniaLotnicza.DodajSamolot(samolot);

            Console.WriteLine("Samolot dodany pomyślnie!");
        }

        private void UsunSamolot()
        {
            Console.WriteLine("== USUWANIE SAMOLOTU ==");
            Console.Write("Podaj id samolotu do usunięcia: ");
            string idSamolotu = Console.ReadLine();

            Samolot samolot = liniaLotnicza.GetSamoloty().Find(s => s.GetId() == idSamolotu);
            if (samolot != null)
            {
                liniaLotnicza.UsunSamolot(samolot);
                Console.WriteLine("Samolot usunięty pomyślnie!");
            }
            else
            {
                Console.WriteLine("Nie znaleziono samolotu o podanym id.");
            }
        }

        private void DodajTrase()
        {
            Console.WriteLine("== DODAWANIE TRASY ==");
            Console.Write("Podaj dystans trasy: ");
            float dystans = float.Parse(Console.ReadLine());

            Console.Write("Podaj czas trasy: ");
            float czas = float.Parse(Console.ReadLine());

            Console.Write("Podaj id trasy: ");
            string idTrasy = Console.ReadLine();

            Trasa trasa = new Trasa(dystans, czas, new List<Lotnisko>(), idTrasy);
            liniaLotnicza.DodajTrase(trasa);

            Console.WriteLine("Trasa dodana pomyślnie!");
        }

        private void UsunTrase()
        {
            Console.WriteLine("== USUWANIE TRASY ==");
            Console.Write("Podaj nazwę trasy do usunięcia: ");
            string nazwaTrasy = Console.ReadLine();

            Trasa trasa = liniaLotnicza.GetTrasa().Find(t => t.GetID() == nazwaTrasy);
            if (trasa != null)
            {
                liniaLotnicza.UsunTrase(trasa);
                Console.WriteLine("Trasa usunięta pomyślnie!");
            }
            else
            {
                Console.WriteLine("Nie znaleziono trasy o podanej nazwie.");
            }
        }

        private void WyswietlSamoloty()
        {
            Console.WriteLine("== LISTA SAMOLOTÓW ==");
            List<Samolot> samoloty = liniaLotnicza.GetSamoloty();

            if (samoloty.Count > 0)
            {
                foreach (Samolot samolot in samoloty)
                {
                    Console.WriteLine($"- ID: {samolot.GetId()}");
                }
            }
            else
            {
                Console.WriteLine("Brak samolotów w linii lotniczej.");
            }
        }

        private void WyswietlTrasy()
        {
            Console.WriteLine("== LISTA TRAS ==");
            List<Trasa> trasy = liniaLotnicza.GetTrasa();

            if (trasy.Count > 0)
            {
                foreach (Trasa trasa in trasy)
                {
                    Console.WriteLine($"- ID: {trasa.GetID()}");
                }
            }
            else
            {
                Console.WriteLine("Brak tras w linii lotniczej.");
            }
        }
    }

}
