namespace Pokedex.Api.DTO.Builder
{
    public class TreinadorDTOBuilder
    {
        private TreinadorDTO _treinadorDTO = new TreinadorDTO();

        public TreinadorDTOBuilder WithPNome(string pnome)
        {
            _treinadorDTO.PNome = pnome;
            return this;
        }

        public TreinadorDTOBuilder WithSNome(string snome)
        {
            _treinadorDTO.SNome = snome;
            return this;
        }

        public TreinadorDTOBuilder WithLogin(string login)
        {
            _treinadorDTO.Login = login;
            return this;
        }

        public TreinadorDTO Build()
        {
            return _treinadorDTO;
        } 

    }
}