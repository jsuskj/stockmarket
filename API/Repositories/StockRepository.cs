using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using API.Data;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories
{
    public class StockRepository : IStockRepository
    {
        private readonly StockContext _context;
        public StockRepository(StockContext context)
        {
            _context = context;
        }

        public async Task<Stock> GetStockByIdAsync(int id)
        {
            return await _context.Stocks.FindAsync(id);
        }

        public async Task<IReadOnlyList<Stock>> GetStocksAsync()
        {
            return await  _context.Stocks.ToListAsync();
        }


        public async Task<Stock> AddStock(Stock stock)
        {            
            await _context.Stocks.AddAsync(stock);
            await _context.SaveChangesAsync();

            return stock;
        }

        public async Task<bool> DeleteStock(Stock stock)
        {
             _context.Stocks.Remove(stock);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}