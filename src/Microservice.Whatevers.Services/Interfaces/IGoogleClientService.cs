using System.Threading;
using System.Threading.Tasks;
using Microservice.Whatevers.Services.Models;

namespace Microservice.Whatevers.Services
{
    public interface IGoogleClientService
    {
        Task<GoogleClientModel> GetAsync(CancellationToken cancellationToken);
    }
}