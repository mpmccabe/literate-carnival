using Points.Shared.Models;

namespace Points.API.Models
{

    public class ModuleRepository : IModuleRepository
    {
        private readonly PointsDbContext _pointsDbContext;

        public ModuleRepository(PointsDbContext pointsDbContext)
        {
            _pointsDbContext = pointsDbContext;
        }

        public IEnumerable<Module> GetAllModules()
        {
            return _pointsDbContext.Modules;
        }
    }
}
