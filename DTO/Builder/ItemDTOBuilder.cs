using Microsoft.AspNetCore.Http.Features;
using Pokedex.Api.Models;

namespace Pokedex.Api.DTO.Builder
{
    public class ItemDTOBuilder
    {
        private ItemDTO _itemDTO = new ItemDTO();

        public ItemDTOBuilder WithNome(string nome)
        {
            _itemDTO.Nome = nome;
            return this;
        }

        public ItemDTOBuilder WithPtVida(int ptVida)
        {
            _itemDTO.PtVida = ptVida;
            return this;
        }
        
        public ItemDTOBuilder WithPtDefesa(int ptDefesa)
        {
            _itemDTO.PtDefesa = ptDefesa;
            return this;
        }

        public ItemDTOBuilder WithPtAtaque(int ptAtaque)
        {
            _itemDTO.PtAtaque = ptAtaque;
            return this;
        }

        public ItemDTOBuilder WithDescricao(string descricao)
        {
            _itemDTO.Descricao = descricao;
            return this;
        }

        public ItemDTO Build()
        {
            return _itemDTO;
        }
    }
}