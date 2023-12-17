using Pokedex.Api.Repositories.Interfaces;
using Pokedex.Api.Services.Interfaces;
using Pokedex.Api.Models;
using Pokedex.Api.Exceptions;
using Pokedex.Api.Repositories.UnitOfWork;

namespace Pokedex.Api.Services
{
    public class ItensService : IItensService
    {
        private readonly IItensRepository _itensRepository;
        private readonly IUnitOfWork _unitOfWork;
        public ItensService(IItensRepository itensRepository, IUnitOfWork unitOfWork)
        {
            _itensRepository = itensRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Item>> GetAllItensAsync()
        {
            IEnumerable<Item> itens = await _itensRepository.GetAllItensAsync();

            if(itens is null)
            {
                throw new NotFoundException("Nenhum item foi encontrado");
            }

            return itens;
        }

        public async Task<Item> GetByIdItemAsync(int id)
        {
            Item item = await _itensRepository.GetByIdItensAsync(id);

            if(item is null)
            {
                throw new NotFoundException("Nenhum item foi encontrado");
            }

            return item;
        }

        public async Task<Item> PostItemAsync(Item item)
        {
            
            if(item.PtVida > 100)
            {
                throw new Exception("Um item não pode recuperar mais de 100 de HP");               
            }
            
            if(item.PtAtaque > 40)
            {
                throw new Exception("Um item não pode aumentar mais de 40 de ataque");               
            }

            if(item.PtDefesa > 40)
            {
                throw new Exception("Um item não pode aumentar mais de 40 de defesa");
            }

            await _itensRepository.PostAsync(item);
            await _unitOfWork.SaveChangesAsync();
            return item;
        }

        public async Task<Item> UpdateItemAsync(int id, Item alteracaoItem)
        {
            Item item = await _itensRepository.GetByIdItensAsync(id);

            if(item is null)
            {
                throw new NotFoundException("Nenhum item foi encontrado");
            }

            item.Nome = alteracaoItem.Nome;
            item.Descricao = alteracaoItem.Descricao;
            item.PtVida = alteracaoItem.PtVida;
            item.PtDefesa = alteracaoItem.PtDefesa;
            item.PtAtaque = alteracaoItem.PtAtaque;
            item.Elemento = alteracaoItem.Elemento;
            await _unitOfWork.SaveChangesAsync();

            return item;
        }

        public async Task DeleteItemAsync(int id)
        {
            Item item = await _itensRepository.GetByIdItensAsync(id);

            if(item is null)
            {
                throw new NotFoundException("Nenhum item foi encontrado");
            }

            await _itensRepository.DeleteItemAsync(id);
        }



    }
}