using Json.DataCollector;

namespace Json.Service;

public static class RelationshipManager
{
    public static void Configure(DataContext dataContext)
    {
        ConfigureCaretakers(dataContext);
        ConfigureDetailResults(dataContext);
        ConfigureHorses(dataContext);
        ConfigureJockeys(dataContext);
        ConfigureParticipants(dataContext);
        ConfigureRaces(dataContext);
        ConfigureStadiums(dataContext);
    }

    private static void ConfigureCaretakers(DataContext dataContext)
    {
        dataContext.Caretakers[0].Address = dataContext.Addresses[0];
        dataContext.Caretakers[1].Address = dataContext.Addresses[1];
        dataContext.Caretakers[2].Address = dataContext.Addresses[2];
        dataContext.Caretakers[3].Address = dataContext.Addresses[3];


        dataContext.Caretakers[0].Horses =
        [
            dataContext.Horses[0],
            dataContext.Horses[2],
            dataContext.Horses[3],
        ];

        dataContext.Caretakers[1].Horses =
        [
            dataContext.Horses[1],
        ];

        dataContext.Caretakers[2].Horses =
        [
            dataContext.Horses[0],
            dataContext.Horses[3],
        ];

        dataContext.Caretakers[3].Horses =
        [
            dataContext.Horses[0],
            dataContext.Horses[1],
            dataContext.Horses[2],
            dataContext.Horses[3],
        ];
    }

    private static void ConfigureDetailResults(DataContext dataContext)
    {
        dataContext.DetailResults[0].Participant = dataContext.Participants[0];
        dataContext.DetailResults[1].Participant = dataContext.Participants[1];
        dataContext.DetailResults[2].Participant = dataContext.Participants[2];
        dataContext.DetailResults[3].Participant = dataContext.Participants[3];
        dataContext.DetailResults[4].Participant = dataContext.Participants[4];
        dataContext.DetailResults[5].Participant = dataContext.Participants[5];
        dataContext.DetailResults[6].Participant = dataContext.Participants[6];
        dataContext.DetailResults[7].Participant = dataContext.Participants[7];
    }

    private static void ConfigureHorses(DataContext dataContext)
    {
        dataContext.Horses[0].Caretakers =
        [
            dataContext.Caretakers[0],
            dataContext.Caretakers[2],
            dataContext.Caretakers[3],
        ];

        dataContext.Horses[1].Caretakers =
        [
            dataContext.Caretakers[1],
            dataContext.Caretakers[3],
        ];

        dataContext.Horses[2].Caretakers =
        [
            dataContext.Caretakers[0],
            dataContext.Caretakers[3],
        ];

        dataContext.Horses[3].Caretakers =
        [
            dataContext.Caretakers[0],
            dataContext.Caretakers[2],
            dataContext.Caretakers[3],
        ];


        dataContext.Horses[0].Participants =
        [
            dataContext.Participants[0],
            dataContext.Participants[1],
        ];

        dataContext.Horses[1].Participants =
        [
            dataContext.Participants[2],
            dataContext.Participants[3],
        ];

        dataContext.Horses[2].Participants =
        [
            dataContext.Participants[4],
            dataContext.Participants[5],
        ];

        dataContext.Horses[3].Participants =
        [
            dataContext.Participants[6],
            dataContext.Participants[7],
        ];
    }

    private static void ConfigureJockeys(DataContext dataContext)
    {
        dataContext.Jockeys[0].Address = dataContext.Addresses[4];
        dataContext.Jockeys[1].Address = dataContext.Addresses[5];
        dataContext.Jockeys[2].Address = dataContext.Addresses[6];
        dataContext.Jockeys[3].Address = dataContext.Addresses[7];
        dataContext.Jockeys[4].Address = dataContext.Addresses[8];

        dataContext.Jockeys[0].Participants =
        [
            dataContext.Participants[0],
            dataContext.Participants[1],
        ];

        dataContext.Jockeys[1].Participants =
        [
            dataContext.Participants[2],
            dataContext.Participants[3],
        ];

        dataContext.Jockeys[2].Participants =
        [
            dataContext.Participants[4],
            dataContext.Participants[5],
        ];

        dataContext.Jockeys[3].Participants =
        [
            dataContext.Participants[6],
        ];

        dataContext.Jockeys[4].Participants =
        [
            dataContext.Participants[7],
        ];
    }

    private static void ConfigureParticipants(DataContext dataContext)
    {
        dataContext.Participants[0].Jockey = dataContext.Jockeys[0];
        dataContext.Participants[1].Jockey = dataContext.Jockeys[0];
        dataContext.Participants[2].Jockey = dataContext.Jockeys[1];
        dataContext.Participants[3].Jockey = dataContext.Jockeys[1];
        dataContext.Participants[4].Jockey = dataContext.Jockeys[2];
        dataContext.Participants[5].Jockey = dataContext.Jockeys[2];
        dataContext.Participants[6].Jockey = dataContext.Jockeys[3];
        dataContext.Participants[7].Jockey = dataContext.Jockeys[4];

        dataContext.Participants[0].Horse = dataContext.Horses[0];
        dataContext.Participants[1].Horse = dataContext.Horses[0];
        dataContext.Participants[2].Horse = dataContext.Horses[1];
        dataContext.Participants[3].Horse = dataContext.Horses[1];
        dataContext.Participants[4].Horse = dataContext.Horses[2];
        dataContext.Participants[5].Horse = dataContext.Horses[2];
        dataContext.Participants[6].Horse = dataContext.Horses[3];
        dataContext.Participants[7].Horse = dataContext.Horses[3];

        dataContext.Participants[0].DetailResult = dataContext.DetailResults[0];
        dataContext.Participants[1].DetailResult = dataContext.DetailResults[1];
        dataContext.Participants[2].DetailResult = dataContext.DetailResults[2];
        dataContext.Participants[3].DetailResult = dataContext.DetailResults[3];
        dataContext.Participants[4].DetailResult = dataContext.DetailResults[4];
        dataContext.Participants[5].DetailResult = dataContext.DetailResults[5];
        dataContext.Participants[6].DetailResult = dataContext.DetailResults[6];
        dataContext.Participants[7].DetailResult = dataContext.DetailResults[7];

        dataContext.Participants[0].Race = dataContext.Races[0];
        dataContext.Participants[1].Race = dataContext.Races[0];
        dataContext.Participants[2].Race = dataContext.Races[0];
        dataContext.Participants[3].Race = dataContext.Races[0];
        dataContext.Participants[4].Race = dataContext.Races[1];
        dataContext.Participants[5].Race = dataContext.Races[1];
        dataContext.Participants[6].Race = dataContext.Races[1];
        dataContext.Participants[7].Race = dataContext.Races[1];
    }

    private static void ConfigureRaces(DataContext dataContext)
    {
        dataContext.Races[0].Stadium = dataContext.Stadiums[0];
        dataContext.Races[1].Stadium = dataContext.Stadiums[1];

        dataContext.Races[0].Participants =
        [
            dataContext.Participants[0],
            dataContext.Participants[1],
            dataContext.Participants[2],
            dataContext.Participants[3],
        ];

        dataContext.Races[1].Participants =
        [
            dataContext.Participants[4],
            dataContext.Participants[5],
            dataContext.Participants[6],
            dataContext.Participants[7],
        ];
    }

    private static void ConfigureStadiums(DataContext dataContext)
    {
        dataContext.Stadiums[0].Address = dataContext.Addresses[9];
        dataContext.Stadiums[1].Address = dataContext.Addresses[10];


        dataContext.Stadiums[0].Races =
        [
            dataContext.Races[0],
        ];

        dataContext.Stadiums[1].Races =
        [
            dataContext.Races[1],
        ];
    }
}