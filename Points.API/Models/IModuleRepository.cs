using Points.Shared.Models;

namespace Points.API.Models
{
    public interface IModuleRepository
    {
        IEnumerable<Module> GetAllModules();
    }
}