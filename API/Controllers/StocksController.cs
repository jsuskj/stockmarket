using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StocksController : ControllerBase
    {

        private static readonly Stock[] AllStocks =
        {
            new Stock(1, "Freezing", "Lorem ipsum dolor sit amet, consectetuer", 120),
            new Stock(2, "Bracing", "Donec pede justo, fringilla vel, aliquet nec", 340),
            new Stock(3, "Chilly", "Aenean vulputate eleifend tellus", 888),
            new Stock(4, "Cool", "Duis arcu tortor, suscipit eget, imperdiet nec", 1020)
        };
        private readonly StockContext _context;

        public StocksController(StockContext context)
        {
            _context = context;
        }

        // get all stocks  HttpGet
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Stock>>> GetStocks()
        {
            var stocks = await  _context.Stocks.ToListAsync();
            return Ok(stocks);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Stock>> GetStockById(int id)
        {
            return await _context.Stocks.FirstOrDefaultAsync(x => x.Id == id);                    
        }

        // creating stocks HttpPost


        // updating stocks HttpPut
    }
}