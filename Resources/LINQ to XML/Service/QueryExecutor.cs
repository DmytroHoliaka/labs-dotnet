using LINQ_to_XML.DTO;
using LINQ_to_XML.Entities;

namespace LINQ_to_XML.Service
{
    internal class QueryExecutor
    {
        private readonly QueryManager _manager;
        public event Action<string?>? InfoNotify;
        public event Action<string?>? ResultNotify;
        public event Action<string?>? ErrorNotify;

        public QueryExecutor(QueryManager? manager)
        {
            if (manager is null)
            {
                throw new ArgumentNullException(nameof(manager), "QueryManager instance cannot be null");
            }

            _manager = manager;
        }

        public void Execute(int choice)
        {
            switch (choice)
            {
                case 1:
                    ProcessCase1();
                    break;
                case 2:
                    ProcessCase2();
                    break;
                case 3:
                    ProcessCase3();
                    break;
                case 4:
                    ProcessCase4();
                    break;
                case 5:
                    ProcessCase5();
                    break;
                case 6:
                    ProcessCase6();
                    break;
                case 7:
                    ProcessCase7();
                    break;
                case 8:
                    ProcessCase8();
                    break;
                case 9:
                    ProcessCase9();
                    break;
                case 10:
                    ProcessCase10();
                    break;
                case 11:
                    ProcessCase11();
                    break;
                case 12:
                    ProcessCase12();
                    break;
                case 13:
                    ProcessCase13();
                    break;
                case 14:
                    ProcessCase14();
                    break;
                case 15:
                    ProcessCase15();
                    break;
                case 16:
                    ProcessCase16();
                    break;
                case 17:
                    ProcessCase17();
                    break;
                case 18:
                    ProcessCase18();
                    break;
                case 19:
                    ProcessCase19();
                    break;
                case 20:
                    ProcessCase20();
                    break;
                case 21:
                    ProcessCase21();
                    break;
                case 22:
                    ProcessCase22();
                    break;
                case 23:
                    ProcessCase23();
                    break;
                default:
                    ErrorNotify?.Invoke("Entered incorrect value. Choice must be an integer number in range [1; 23].");
                    ErrorNotify?.Invoke("\n");
                    break;
            }
        }

        private void ProcessCase1()
        {
            InfoNotify?.Invoke("Enter horse breed: ");
            string? breed = Console.ReadLine();
            IEnumerable<HorseInfo> horses = _manager.GetHorsesByBreed(breed);
            Printer.PrintSequence(horses, ResultNotify);
        }

        private void ProcessCase2()
        {
            InfoNotify?.Invoke("Enter jockey's country: ");
            string? country = Console.ReadLine();
            IEnumerable<JockeyCountry> horses = _manager.GetJockeysFromCountry(country);
            Printer.PrintSequence(horses, ResultNotify);
        }

        private void ProcessCase3()
        {
            StadiumInfo stadium = _manager.GetStadiumWithLongestTrack();
            Printer.PrintSingle(stadium, ResultNotify);
        }

        private void ProcessCase4()
        {
            JockeyWins jockey = _manager.GetTopWinningJockey();
            Printer.PrintSingle(jockey, ResultNotify);
        }

        private void ProcessCase5()
        {
            InfoNotify?.Invoke("Enter year: ");
            string? line = Console.ReadLine();
            int minYear = 2018;
            int maxYear = DateTime.Now.Year;

            if (Validator.IsInt32(line) == true)
            {
                int year = Convert.ToInt32(line);

                if (Validator.IsInRange(year, minYear, maxYear) == true)
                {
                    IEnumerable<RaceInfo> races = _manager.GetRacesByYear(year);
                    Printer.PrintSequence(races, ResultNotify);
                }
                else
                {
                    ErrorNotify?.Invoke($"Entered incorrect range. Year must in range [{minYear}; {maxYear}]");
                    ErrorNotify?.Invoke("\n");
                }
            }
            else
            {
                ErrorNotify?.Invoke($"Entered incorrect value. Year must be integer number");
                ErrorNotify?.Invoke("\n");
            }
        }

        private void ProcessCase6()
        {
            IEnumerable<JockeyRaceCount> jockeys = _manager.GetJockeysWithMultipleRaces();
            Printer.PrintSequence(jockeys, ResultNotify);
        }

        private void ProcessCase7()
        {
            InfoNotify?.Invoke("Enter city: ");
            string? city = Console.ReadLine();
            IEnumerable<CaretakerCity> caretakers = _manager.GetCaretakersByCity(city);
            Printer.PrintSequence(caretakers, ResultNotify);
        }

        private void ProcessCase8()
        {
            InfoNotify?.Invoke("Enter horse breed: ");
            string? breed = Console.ReadLine();
            IEnumerable<CaretakerBreed> caretakers = _manager.GetCaretakersForBreed(breed);
            Printer.PrintSequence(caretakers, ResultNotify);
        }

        private void ProcessCase9()
        {
            HorseSpeed horse = _manager.GetFastestHorse();
            Printer.PrintSingle(horse, ResultNotify);
        }

        private void ProcessCase10()
        {
            InfoNotify?.Invoke("Enter bottom range age: ");
            string? line = Console.ReadLine();
            int minAge = 18;
            int maxAge = 100;

            if (Validator.IsInt32(line) == true)
            {
                int age = Convert.ToInt32(line);

                if (Validator.IsInRange(age, minAge, maxAge) == true)
                {
                    IEnumerable<JockeyAge> jockeys = _manager.GetJockeysByAge(age);
                    Printer.PrintSequence(jockeys, ResultNotify);
                }
                else
                {
                    ErrorNotify?.Invoke($"Entered incorrect range. Age must be in range [{minAge}; {maxAge}]");
                    ErrorNotify?.Invoke("\n");
                }
            }
            else
            {
                ErrorNotify?.Invoke($"Entered incorrect value. Age must be an integer number");
                ErrorNotify?.Invoke("\n");
            }
        }

        private void ProcessCase11()
        {
            InfoNotify?.Invoke("Enter horse nickname: ");
            string? nickname = Console.ReadLine();
            IEnumerable<JockeyHorseCount> jockeys = _manager.GetJockeysForHorseNickname(nickname);
            Printer.PrintSequence(jockeys, ResultNotify);
        }

        private void ProcessCase12()
        {
            InfoNotify?.Invoke("Enter horse age: ");
            string? line = Console.ReadLine();
            int minAge = 1;
            int maxAge = 20;

            if (Validator.IsInt32(line) == true)
            {
                int age = Convert.ToInt32(line);

                if (Validator.IsInRange(age, minAge, maxAge) == true)
                {
                    IEnumerable<RaceHorseCount> races = _manager.GetRacesWithOlderHorses(age);
                    Printer.PrintSequence(races, ResultNotify);
                }
                else
                {
                    ErrorNotify?.Invoke($"Entered incorrect range. Age must be in range [{minAge}; {maxAge}]");
                    ErrorNotify?.Invoke("\n");
                }
            }
            else
            {
                ErrorNotify?.Invoke($"Entered incorrect value. Age must be an integer number");
                ErrorNotify?.Invoke("\n");
            }
        }

        private void ProcessCase13()
        {
            InfoNotify?.Invoke("Enter bottom limit of caretaker salary: ");
            string? line = Console.ReadLine();
            int minSalary = 0;
            int maxSalary = 100000;

            if (Validator.IsInt32(line) == true)
            {
                int salary = Convert.ToInt32(line);

                if (Validator.IsInRange(salary, minSalary, maxSalary) == true)
                {
                    IEnumerable<CaretakerInfo> caretakers = _manager.GetCaretakersByEarnings(salary);
                    Printer.PrintSequence(caretakers, ResultNotify);
                }
                else
                {
                    ErrorNotify?.Invoke($"Entered incorrect range. Salary must be in range [{minSalary}; {maxSalary}]");
                    ErrorNotify?.Invoke("\n");
                }
            }
            else
            {
                ErrorNotify?.Invoke($"Entered incorrect value. Salary must be an integer number");
                ErrorNotify?.Invoke("\n");
            }
        }

        private void ProcessCase14()
        {
            IEnumerable<HorseInfo> horses = _manager.GetHorsesWithVet();
            Printer.PrintSequence(horses, ResultNotify);
        }

        private void ProcessCase15()
        {
            StadiumSpeed stadium = _manager.GetRecordSpeedStadium();
            Printer.PrintSingle(stadium, ResultNotify);
        }

        private void ProcessCase16()
        {
            string separator = "\n\n";
            IEnumerable<Participant> participants = _manager.GetParticipants();
            Printer.PrintSequence(participants, ResultNotify, separator);
        }

        private void ProcessCase17()
        {
            string separator = "\n\n";
            IEnumerable<DetailResult> detailResults = _manager.GetDetailResults();
            Printer.PrintSequence(detailResults, ResultNotify, separator);
        }

        private void ProcessCase18()
        {
            string separator = "\n\n";
            IEnumerable<Jockey> jockeys = _manager.GetJockeys();
            Printer.PrintSequence(jockeys, ResultNotify, separator);
        }

        private void ProcessCase19()
        {
            string separator = "\n\n";
            IEnumerable<Address> addresses = _manager.GetAddresses();
            Printer.PrintSequence(addresses, ResultNotify, separator);
        }

        private void ProcessCase20()
        {
            string separator = "\n\n";
            IEnumerable<Caretaker> caretakers = _manager.GetCaretakers();
            Printer.PrintSequence(caretakers, ResultNotify, separator);
        }

        private void ProcessCase21()
        {
            string separator = "\n\n";
            IEnumerable<Horse> horses = _manager.GetHorses();
            Printer.PrintSequence(horses, ResultNotify, separator);
        }

        private void ProcessCase22()
        {
            string separator = "\n\n";
            IEnumerable<Race> races = _manager.GetRaces();
            Printer.PrintSequence(races, ResultNotify, separator);
        }

        private void ProcessCase23()
        {
            string separator = "\n\n";
            IEnumerable<Stadium> stadiums = _manager.GetStadiums();
            Printer.PrintSequence(stadiums, ResultNotify, separator);
        }
    }
}
