using EVRAZtransport.Interfaces;
using EVRAZtransport.Models;

namespace EVRAZtransport.Mocks
{
    public class MockBus_Stop : IAllBusStops
    {
        private readonly IStopsRoute _routeStops = new MockRoute();
        public IEnumerable<Bus_Stop> Bus_Stops
        {
            get
            {
                return new List<Bus_Stop>
                {
                    new Bus_Stop
                    {
                        Name_Stop = "пр. Уральский \"Алеся\"",
                        Description_Stop = "Время отправления автобусов: 6-00, 6-10, 6-20, 6-25, 6-30, 6-35, 6-40, 6-50, 7-00, 7-15, 7-30, 18-30, 18-40",
                        Coordinates = "57.88413, 59.95719",
                        Name_Route = "1. пр. Уральский - Комсомольская (через город)",
                        Route = _routeStops.Routes.First()
                    },
                    new Bus_Stop
                    {
                        Name_Stop = "'Уральский клинический центр",
                        Description_Stop = "Время отправления автобусов: 6-03, 6-13, 6-23, 6-28, 6-33, 6-38, 6-43, 6-53, 7-03, 7-18, 7-33, 18-33, 18-43",
                        Coordinates = "57.87899, 59.95723",
                        Name_Route = "1. пр. Уральский - Комсомольская (через город)",
                        Route = _routeStops.Routes.First()
                    },
                    new Bus_Stop
                    {
                        Name_Stop = "м–н \"Минимарт\"",
                        Description_Stop = "'Время отправления автобусов: 6-06, 6-16, 6-26, 6-31, 6-36, 6-41, 6-46, 6-56, 7-06, 7-21, 7-36, 18-36, 18-46",
                        Coordinates = "57.88413, 59.95719",
                        Name_Route = "1. пр. Уральский - Комсомольская (через город)",
                        Route = _routeStops.Routes.First()
                    },
                    new Bus_Stop
                    {
                        Name_Stop = "пр. Уральский \"Алеся\"",
                        Description_Stop = "Время отправления автобусов: 6-00, 6-10, 6-20, 6-25, 6-30, 6-35, 6-40, 6-50, 7-00, 7-15, 7-30, 18-30, 18-40",
                        Coordinates = "57.88413, 59.95719",
                        Name_Route = "1. пр. Уральский - Комсомольская (через город)",
                        Route = _routeStops.Routes.First()
                    },
                    new Bus_Stop
                    {
                        Name_Stop = "пр. Уральский \"Алеся\"",
                        Description_Stop = "Время отправления автобусов: 6-00, 6-10, 6-20, 6-25, 6-30, 6-35, 6-40, 6-50, 7-00, 7-15, 7-30, 18-30, 18-40",
                        Coordinates = "57.88413, 59.95719",
                        Name_Route = "1. пр. Уральский - Комсомольская (через город)",
                        Route = _routeStops.Routes.First()
                    },
                    new Bus_Stop
                    {
                        Name_Stop = "пр. Уральский \"Алеся\"",
                        Description_Stop = "Время отправления автобусов: 6-00, 6-10, 6-20, 6-25, 6-30, 6-35, 6-40, 6-50, 7-00, 7-15, 7-30, 18-30, 18-40",
                        Coordinates = "57.88413, 59.95719",
                        Name_Route = "1. пр. Уральский - Комсомольская (через город)",
                        Route = _routeStops.Routes.First()
                    },
                    new Bus_Stop
                    {
                        Name_Stop = "пр. Уральский \"Алеся\"",
                        Description_Stop = "Время отправления автобусов: 6-00, 6-10, 6-20, 6-25, 6-30, 6-35, 6-40, 6-50, 7-00, 7-15, 7-30, 18-30, 18-40",
                        Coordinates = "57.88413, 59.95719",
                        Name_Route = "1. пр. Уральский - Комсомольская (через город)",
                        Route = _routeStops.Routes.First()
                    },
                    new Bus_Stop
                    {
                        Name_Stop = "пр. Уральский \"Алеся\"",
                        Description_Stop = "Время отправления автобусов: 6-00, 6-10, 6-20, 6-25, 6-30, 6-35, 6-40, 6-50, 7-00, 7-15, 7-30, 18-30, 18-40",
                        Coordinates = "57.88413, 59.95719",
                        Name_Route = "1. пр. Уральский - Комсомольская (через город)",
                        Route = _routeStops.Routes.First()
                    },
                    new Bus_Stop
                    {
                        Name_Stop = "пр. Уральский \"Алеся\"",
                        Description_Stop = "Время отправления автобусов: 6-00, 6-10, 6-20, 6-25, 6-30, 6-35, 6-40, 6-50, 7-00, 7-15, 7-30, 18-30, 18-40",
                        Coordinates = "57.88413, 59.95719",
                        Name_Route = "1. пр. Уральский - Комсомольская (через город)",
                        Route = _routeStops.Routes.First()
                    },
                    new Bus_Stop
                    {
                        Name_Stop = "пр. Уральский \"Алеся\"",
                        Description_Stop = "Время отправления автобусов: 6-00, 6-10, 6-20, 6-25, 6-30, 6-35, 6-40, 6-50, 7-00, 7-15, 7-30, 18-30, 18-40",
                        Coordinates = "57.88413, 59.95719",
                        Name_Route = "1. пр. Уральский - Комсомольская (через город)",
                        Route = _routeStops.Routes.First()
                    },
                    new Bus_Stop
                    {
                        Name_Stop = "пр. Уральский \"Алеся\"",
                        Description_Stop = "Время отправления автобусов: 6-00, 6-10, 6-20, 6-25, 6-30, 6-35, 6-40, 6-50, 7-00, 7-15, 7-30, 18-30, 18-40",
                        Coordinates = "57.88413, 59.95719",
                        Name_Route = "1. пр. Уральский - Комсомольская (через город)",
                        Route = _routeStops.Routes.First()
                    },

                };
            }
        }

        public Bus_Stop getObjectBusStop(string Name_Stop)
        {
            throw new NotImplementedException();
        }
    }
}
