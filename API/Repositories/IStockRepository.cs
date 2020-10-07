using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Repositories
{
    public interface IStockRepository
    {
       
        Task<Stock> GetStockByIdAsync(int id);
        Task<IReadOnlyList<Stock>> GetStocksAsync();      




    }
}