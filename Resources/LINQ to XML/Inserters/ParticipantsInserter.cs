using LINQ_to_XML.Entities;

namespace LINQ_to_XML.Inserters
{
    internal class ParticipantsInserter
    {
        public static void InsertParticipants(List<Participant>? participants)
        {
            if (participants is null)
            {
                throw new ArgumentNullException(nameof(participants), "Input list of participants cannot be null");
            }

            Participant participant1 = new()
            {
                Id = 1,
                Number = 101,
                JockeyId = 1,
                HorseId = 3,
                RaceId = 1
            };

            Participant participant2 = new()
            {
                Id = 2,
                Number = 102,
                JockeyId = 2,
                HorseId = 2,
                RaceId = 1
            };

            Participant participant3 = new()
            {
                Id = 3,
                Number = 103,
                JockeyId = 3,
                HorseId = 1,
                RaceId = 1
            };

            Participant participant4 = new()
            {
                Id = 4,
                Number = 104,
                JockeyId = 4,
                HorseId = 2,
                RaceId = 1
            };

            Participant participant5 = new()
            {
                Id = 5,
                Number = 105,
                JockeyId = 1,
                HorseId = 3,
                RaceId = 2
            };

            Participant participant6 = new()
            {
                Id = 6,
                Number = 106,
                JockeyId = 4,
                HorseId = 1,
                RaceId = 2
            };

            Participant participant7 = new()
            {
                Id = 7,
                Number = 107,
                JockeyId = 2,
                HorseId = 3,
                RaceId = 2
            };

            Participant participant8 = new()
            {
                Id = 8,
                Number = 108,
                JockeyId = 4,
                HorseId = 1,
                RaceId = 2
            };

            participants.AddRange(new List<Participant>()
            {
                participant1,
                participant2,
                participant3,
                participant4,
                participant5,
                participant6,
                participant7,
                participant8,
            });
        }
    }
}
