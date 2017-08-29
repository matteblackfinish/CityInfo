using CityInfo.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            //init dummy data

            Cities = new List<CityDto>()
            {
                new CityDto
                {
                    Id = 1,
                    Name = "NYC",
                    Description = "The city with the big park",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Central Park",
                            Description = "Big ass park"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Empire State Building",
                            Description = "Big ass building"
                        }
                    }
                },
                new CityDto
                {
                    Id = 2,
                    Name = "StC",
                    Description = "St. Catharines baby",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Montebello Park",
                            Description = "Lame ass park"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "MTO Building",
                            Description = "Work ass building"
                        }
                    }
                },
                new CityDto
                {
                    Id = 3,
                    Name = "Paris",
                    Description = "So many nice things to see and eat",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Louvre",
                            Description = "Big ass museum"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Eiffel",
                            Description = "Big pointy tower"
                        }
                    }
                }
            };
        }
    }
}
