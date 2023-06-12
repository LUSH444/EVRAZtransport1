using EVRAZtransport.Interfaces;

namespace EVRAZtransport.Mocks
{
    public class MockRoute : IStopsRoute
    {
        private readonly IRoutesSide _routesSide = new MockMovement_Side();
        public IEnumerable<Models.Route> Routes => new List<Route>
        {
            new Models.Route
            {
                Name_Route = "1. пр. Уральский - Комсомольская (через город)",
                Name_Side = "Движение автобусов с внешней стороны ЕВРАЗ НТМК",
                Movement_Side = _routesSide.Movement_Sides.First()
            },
            new Models.Route
            {
                Name_Route = "1. Комсомольская (через город) - пр. Уральский",
                Name_Side = "Движение автобусов с внешней стороны ЕВРАЗ НТМК",
                Movement_Side = _routesSide.Movement_Sides.First()
            }
        };
    }
}
