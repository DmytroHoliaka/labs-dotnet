using LINQ_to_XML.Entities;

namespace LINQ_to_XML.Inserters
{
    internal class DetailResultsInserter
    {
        public static void InsertDetailResults(List<DetailResult>? detailResults)
        {
            if (detailResults is null)
            {
                throw new ArgumentNullException(nameof(detailResults), "Input list of results cannot be null");
            }

            DetailResult detailResult1 = new()
            {
                Id = 1,
                Place = 1,
                Duration = 3600,
                MaxSpeed = 56.5,
                ParticipantId = 1
            };

            DetailResult detailResult2 = new()
            {
                Id = 2,
                Place = 2,
                Duration = 3620,
                MaxSpeed = 55.9,
                ParticipantId = 2
            };

            DetailResult detailResult3 = new()
            {
                Id = 3,
                Place = 3,
                Duration = 3650,
                MaxSpeed = 55.3,
                ParticipantId = 3
            };

            DetailResult detailResult4 = new()
            {
                Id = 4,
                Place = 4,
                Duration = 3700,
                MaxSpeed = 54.8,
                ParticipantId = 4
            };

            DetailResult detailResult5 = new()
            {
                Id = 5,
                Place = 1,
                Duration = 3590,
                MaxSpeed = 56.7,
                ParticipantId = 5
            };

            DetailResult detailResult6 = new()
            {
                Id = 6,
                Place = 2,
                Duration = 3610,
                MaxSpeed = 56.2,
                ParticipantId = 6
            };

            DetailResult detailResult7 = new()
            {
                Id = 7,
                Place = 3,
                Duration = 3640,
                MaxSpeed = 55.6,
                ParticipantId = 7
            };

            DetailResult detailResult8 = new()
            {
                Id = 8,
                Place = 4,
                Duration = 3680,
                MaxSpeed = 55.1,
                ParticipantId = 8
            };


            detailResults.AddRange(new List<DetailResult>()
            {
                detailResult1,
                detailResult2,
                detailResult3,
                detailResult4,
                detailResult5,
                detailResult6,
                detailResult7,
                detailResult8,
            });
        }
    }
}
