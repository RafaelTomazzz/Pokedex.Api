using Pokedex.Api.Models;

namespace Pokedex.Api.Services.Interfaces
{
    public interface IItensService
    {
        public Task<IEnumerable<Item>> GetAllItensAsync();
        public Task<Item> GetByIdItemAsync(int id);
        public Task<Item> PostItemAsync(Item item);
        public Task<Item> UpdateItemAsync(int id, Item alteracaoItem);
        public Task DeleteItemAsync(int id);

    }
}