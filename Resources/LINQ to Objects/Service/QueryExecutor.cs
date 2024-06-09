using LINQ_to_Objects.DTO;

namespace LINQ_to_Objects.Service
{
    internal class QueryExecutor
    {
        public static void Execute(DataContext data, int queryNumber)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            switch (queryNumber)
            {
                case 1:
                    {
                        List<HorseShortInfo> res = QueryManager.GetHorsesByDescendingAge(data.Horses);
                        Printer.PrintList(res);
                        break;
                    }
                case 2:
                    {
                        List<AddressShortInfo> res = QueryManager.GetFilteredAddresses(data.Addresses);
                        Printer.PrintList(res);
                        break;
                    }
                case 3:
                    {
                        PerformCase3(data);
                        break;
                    }
                case 4:
                    {
                        List<CaretakerHorseCountInfo> res = QueryManager.GetCaretakerWithMoreThanOneHorse(data.Caretakers);
                        Printer.PrintList(res);
                        break;
                    }
                case 5:
                    {
                        List<HorseWinsInfo> res = QueryManager.GetHorsesWithMultipleWins(data.Horses, data.Participants, data.DetailResults);
                        Printer.PrintList(res);
                        break;
                    }
                case 6:
                    {
                        List<HorseShortInfo> res = QueryManager.GetHorsesInRacing(data.Horses, data.Participants);
                        Printer.PrintList(res);
                        break;
                    }
                case 7:
                    {
                        List<HorseShortInfo> res = QueryManager.GetHorsesWithoutRacing(data.Horses, data.Participants);
                        Printer.PrintList(res);
                        break;
                    }
                case 8:
                    {
                        PerformCase8(data);
                        break;
                    }
                case 9:
                    {
                        HorseMaxSpeedInfo? res = QueryManager.GetBestSpeedHorse(data.Horses, data.Participants, data.DetailResults);
                        Console.WriteLine(res);
                        break;
                    }
                case 10:
                    {
                        List<JockeyHorseInfo> res = QueryManager.GetJockeysAndHorses(data.Jockeys, data.Horses, data.Participants);
                        Printer.PrintList(res);
                        break;
                    }
                case 11:
                    {
                        StadiumMaxTrackInfo? res = QueryManager.GetStadiumWithMaxTrackLength(data.Stadiums);
                        Console.WriteLine(res);
                        break;
                    }
                case 12:
                    {
                        PerformCase12(data);
                        break;
                    }
                case 13:
                    {
                        PerformCase13(data);
                        break;
                    }
                case 14:
                    {
                        List<HorseTrainerInfo> res = QueryManager.GetHorsesWithTrainer(data.Horses, data.Caretakers);
                        Printer.PrintList(res);
                        break;
                    }
                case 15:
                    {
                        List<JockeyAgeInfo> res = QueryManager.GetVowelNamedJockeysByAgeDesc(data.Jockeys);
                        Printer.PrintList(res);
                        break;
                    }
                case 16:
                    {
                        PerformCase16(data);
                        break;
                    }
                case 17:
                    {
                        PerformCase17(data);
                        break;
                    }
                case 18:
                    {
                        PerformCase18(data);
                        break;
                    }
                case 19:
                    {
                        JockeyWinsInfo? res = QueryManager.GetTopWinningJockey(data.Jockeys, data.Participants, data.DetailResults);
                        Console.WriteLine(res);
                        break;
                    }
                case 20:
                    {
                        PerformCase20(data);
                        break;
                    }
                default:
                    Console.ResetColor();
                    throw new ArgumentOutOfRangeException(nameof(queryNumber), "Incorrect query number");
            }

            Console.ResetColor();
        }

        private static void PerformCase3(DataContext data)
        {
            Console.ResetColor();

            Console.Write("Enter country: ");
            string? country = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;

            if (country is null)
            {
                Console.WriteLine("Country cannot be null");
            }
            else
            {
                List<JockeyCountryInfo> res = QueryManager.GetJockeysInCountry(data.Jockeys, data.Addresses, country);
                Printer.PrintList(res);
            }
        }

        private static void PerformCase8(DataContext data)
        {
            Console.ResetColor();
            
            int minAge = 18;
            int maxAge = 100;
            int currentAge;

            Console.Write($"Enter the minimum age of the jockey [{minAge}; {maxAge}]: ");
            string? userInput = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;

            if (userInput.IsValid() && (currentAge = Convert.ToInt32(userInput)).IsInRange(minAge, maxAge))
            {
                List<JockeyAgeInfo> res = QueryManager.GetJockeysOlderThan(data.Jockeys, currentAge);
                Printer.PrintList(res);
            }
            else
            {
                Console.WriteLine("Entered incorrect age");
            }
        }

        private static void PerformCase12(DataContext data)
        {
            Console.ResetColor();

            Console.Write("Enter caretaker's country: ");
            string? country = Console.ReadLine();

            if (country is null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Country cannot be null");
                return;
            }

            Console.Write("Enter minimum salary of the caretaker: ");
            string? salaryLine = Console.ReadLine();

            int minSalary = 0;
            int maxSalary = 100000;
            int salary;

            Console.ForegroundColor = ConsoleColor.Green;

            if (salaryLine.IsValid() && (salary = Convert.ToInt32(salaryLine)).IsInRange(minSalary, maxSalary))
            {
                List<CaretakerCountryInfo> res = QueryManager.GetCaretakersInCountryWithSalaryAbove(data.Caretakers, data.Addresses, country, salary);
                Printer.PrintList(res);
            }
            else
            {
                Console.WriteLine("Entered incorrect salary");
            }
        }

        private static void PerformCase13(DataContext data)
        {
            Console.ResetColor();

            Console.Write("Enter the race country: ");
            string? country = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;

            if (country is null)
            {
                Console.WriteLine("Country cannot be null");
            }
            else
            {
                List<RaceCountryInfo> res = QueryManager.GetRacesInCountry(data.Races, data.Stadiums, data.Addresses, country);
                Printer.PrintList(res);
            }
        }

        private static void PerformCase16(DataContext data)
        {
            Console.ResetColor();

            Console.Write("Enter the horse breed: ");
            string? breed = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;

            if (breed is null)
            {
                Console.WriteLine("Breed cannot be null");
            }
            else
            {
                List<CaretakerHorseBreedInfo> res = QueryManager.GetCaretakersForBreed(data.Caretakers, data.Horses, breed);
                Printer.PrintList(res);
            }
        }

        private static void PerformCase17(DataContext data)
        {
            Console.ResetColor();

            Console.Write("Enter the horse nickname: ");
            string? nickname = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;

            if (nickname is null)
            {
                Console.WriteLine("The horse nickname cannot be null");
            }
            else
            {
                List<RaceHorseNicknameCount> res = QueryManager.GetRacesByHorseNickname(data.Races, data.Participants, data.Horses, nickname);
                Printer.PrintList(res);
            }
        }

        private static void PerformCase18(DataContext data)
        {
            Console.ResetColor();

            int firstJockeyId = 1;
            int lastJockeyId = 5;
            int currectJockeyId;

            Console.Write($"Enter jockey id [{firstJockeyId}; {lastJockeyId}]: ");
            string? jockeyIdLine = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;

            if (jockeyIdLine.IsValid() && (currectJockeyId = Convert.ToInt32(jockeyIdLine)).IsInRange(firstJockeyId, lastJockeyId))
            {
                List<JockeyHorseInfo> res = QueryManager.GetHorsesRiddenByJockey(data.Jockeys, data.Participants, data.Horses, currectJockeyId);
                Printer.PrintList(res);
            }
            else
            {
                Console.WriteLine("Entered incorrect jockey id");
            }
        }

        private static void PerformCase20(DataContext data)
        {
            Console.ResetColor();

            Console.Write("Enter the stadium country: ");
            string? country = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;

            if (country is null)
            {
                Console.WriteLine("Country cannot be null");
            }
            else
            {
                List<JockeyStadiumCountry> res = QueryManager.GetJockeysByStadiumCountry(data.Jockeys, data.Participants, data.Stadiums, data.Races, data.Addresses, country);
                Printer.PrintList(res);
            }
        }
    }
}
