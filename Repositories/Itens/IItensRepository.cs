using Pokedex.Api.Models;

namespace Pokedex.Api.Repositories.Interfaces
{
    public interface IItensRepository
    {
        public Task<IEnumerable<Item>> GetAllItensAsync();
        public Task<Item> GetByIdItensAsync(int id);
        public Task PostAsync(Item item);
        public Task DeleteItemAsync(int id);
    }
}