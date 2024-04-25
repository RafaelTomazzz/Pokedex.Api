namespace Pokedex.Api.DTO.Builder
{
    public class LoginDTOBuilder
    {
        private LoginDTO _loginDTO = new LoginDTO();

        public LoginDTOBuilder WithLogin(string login)
        {
            _loginDTO.Login = login;
            return this;
        }

        public LoginDTOBuilder WithSenha(string senha)
        {
            _loginDTO.Senha = senha;
            return this;
        }

        public LoginDTO Build()
        {
            return _loginDTO;
        }
    }
}
