using ThirstyHubWeb.Models;

namespace ThirstyHubWeb.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}
