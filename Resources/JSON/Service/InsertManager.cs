using Json.DataCollector;
using Json.Inserters;

namespace Json.Service;

public static class InsertManager
{
    public static void InsertData(DataContext dataContext)
    {
        AddressesInserter.InsertAddresses(dataContext.Addresses);
        CaretakersInserter.InsertCaretakers(dataContext.Caretakers);
        DetailResultsInserter.InsertDetailResults(dataContext.DetailResults);
        HorsesInserter.InsertHorses(dataContext.Horses);
        JockeysInserter.InsertJockeys(dataContext.Jockeys);
        ParticipantsInserter.InsertParticipants(dataContext.Participants);
        RacesInserter.InsertRaces(dataContext.Races);
        StadiumsInserter.InsertStadiums(dataContext.Stadiums);
    }
}