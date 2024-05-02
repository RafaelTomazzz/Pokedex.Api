using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Pokedex.Api.Controllers;
using Pokedex.Api.Data;
using Pokedex.Api.Models;
using Pokedex.Api.Repositories.Interfaces;

namespace Pokedex.Api.Repositories
{
    public class ItemTreinadoresRepository : IItemTreinadoresRepository
    {
        private readonly DataContext _context;
        public ItemTreinadoresRepository (DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ItemTreinador>> GetAllITAsync()
        {
            IEnumerable<ItemTreinador> itemTreinadores = await _context.ItemTreinadores.ToListAsync();
            return itemTreinadores;
        }

        public async Task<ItemTreinador> GetByIdITAsync(int iditem, int idtreinador)
        {
            ItemTreinador itemTreinador = await _context.ItemTreinadores.FirstOrDefaultAsync(ph => ph.IdTreinador == iditem & ph.IdTreinador == idtreinador);
            return itemTreinador;
        }

        public async Task PostITAsync(ItemTreinador itemTreinador)
        {
            _context.AddAsync(itemTreinador);
        }

        public async Task DeleteITAsync(ItemTreinador itemTreinador)
        {
            _context.Remove(itemTreinador);
        }
    }
}