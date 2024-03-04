﻿using LINQ_to_Objects.Entities;

namespace LINQ_to_Objects.Inserters
{
    internal class StadiumsInserter
    {
        public static void InsertStadiums(List<Stadium>? stadiums)
        {
            if (stadiums is null)
            {
                throw new ArgumentNullException(nameof(stadiums), "Input list of stadiums cannot be null");
            }

            Stadium stadium1 = new()
            {
                Id = 1,
                Name = "Silverstone Circuit",
                TrackLength = 5900,
                ParticipantCapacity = 50,
                AudienceCapacity = 150000,
                AddressId = 5
            };

            Stadium stadium2 = new()
            {
                Id = 2,
                Name = "Monaco Grand Prix Circuit",
                TrackLength = 3337,
                ParticipantCapacity = 20,
                AudienceCapacity = 200000,
                AddressId = 6
            };

            stadiums.AddRange(new List<Stadium>()
            {
                stadium1,
                stadium2,
            });
        }
    }
}