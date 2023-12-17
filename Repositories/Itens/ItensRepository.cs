using Microsoft.EntityFrameworkCore;
using Pokedex.Api.Data;
using Pokedex.Api.Models;

namespace Pokedex.Api.Repositories.Interfaces
{
    public class ItensRepository : IItensRepository
    {
        private readonly DataContext _context;

        public ItensRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Item>> GetAllItensAsync()
        {
            IEnumerable<Item> itens = await _context.Itens.ToListAsync();
            return itens;
        }

        public async Task<Item> GetByIdItensAsync(int id)
        {
            Item item = await _context.Itens.FirstOrDefaultAsync(i => i.Id == id);
            return item;
        }

        public async Task PostAsync(Item item)
        {
            await _context.AddAsync(item);
        }

        public async Task DeleteItemAsync(int id)
        {
            Item item = await _context.Itens.FirstOrDefaultAsync(i => i.Id == id);
            _context.Itens.Remove(item); 
        }
    }
}