using Rungroopwebapp.Interfaces;
using Rungroopwebapp.Models;

namespace RunUnity.Interfaces
{
    public interface IDashboardRepository
    {
        Task<List<Race>> GetAllUserRaces();
        Task<List<Club>> GetAllUserClubs();
    }
}
