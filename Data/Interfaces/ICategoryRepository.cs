using ThirstyHubWeb.Data.Models;

namespace ThirstyHubWeb.Data.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}
