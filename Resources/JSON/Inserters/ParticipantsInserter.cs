using Json.Entities;

namespace Json.Inserters
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
            };

            Participant participant2 = new()
            {
                Id = 2,
                Number = 102,
            };

            Participant participant3 = new()
            {
                Id = 3,
                Number = 103,
            };

            Participant participant4 = new()
            {
                Id = 4,
                Number = 104,
            };

            Participant participant5 = new()
            {
                Id = 5,
                Number = 105,
            };

            Participant participant6 = new()
            {
                Id = 6,
                Number = 106,
            };

            Participant participant7 = new()
            {
                Id = 7,
                Number = 107,
            };

            Participant participant8 = new()
            {
                Id = 8,
                Number = 108,
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
