using Pokedex.Api.Exceptions;
using Pokedex.Api.Models;
using Pokedex.Api.Repositories.Interfaces;
using Pokedex.Api.Repositories.UnitOfWork;
using Pokedex.Api.Services.Interfaces;

namespace Pokedex.Api.Services
{
    public class ItemTreinadoresService : IItemTreinadoresService
    {
        private readonly IItemTreinadoresRepository _itemTreinadoresRepository;
        private readonly IUnitOfWork _unitOfWork;
        public ItemTreinadoresService(IItemTreinadoresRepository itemTreinadoresRepository, IUnitOfWork unitOfWork)
        {
            _itemTreinadoresRepository = itemTreinadoresRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<ItemTreinador>> GetAllITAsync()
        {
            IEnumerable<ItemTreinador> itemTreinadores = await _itemTreinadoresRepository.GetAllITAsync();

            if(itemTreinadores is null)
            {
                throw new NotFoundException("Nenhum PokemonTreinador foi encontrado");
            }

            return itemTreinadores;
        }

        public async Task<ItemTreinador> GetByIdITAsync(int iditem, int idtreinador)
        {
            ItemTreinador itemTreinadores = await _itemTreinadoresRepository.GetByIdITAsync(iditem, idtreinador);

            if(itemTreinadores is null)
            {
                throw new NotFoundException("Nenhum PokemonTreinador foi encontrado");
            }

            return itemTreinadores;
        }

        public async Task<ItemTreinador> PostITAsync(ItemTreinador novoItemTreinador)
        {
            ItemTreinador itemTreinador = await _itemTreinadoresRepository.GetByIdITAsync(novoItemTreinador.IdItem, novoItemTreinador.IdTreinador);

            if(itemTreinador != null)
            {
                throw new Exception("Este pokemon já tem esta habilidade");
            }

            await _itemTreinadoresRepository.PostITAsync(novoItemTreinador);
            await _unitOfWork.SaveChangesAsync();
            return novoItemTreinador;
        }

        public async Task DeleteITAsync(int iditem, int idtreinador)
        {
            ItemTreinador itemTreinador = await _itemTreinadoresRepository.GetByIdITAsync(iditem, idtreinador);

            if(itemTreinador is null)
            {
                throw new NotFoundException("Nenhum PokemonTreinador foi encontrado");
            }

            await _itemTreinadoresRepository.DeleteITAsync(itemTreinador);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}