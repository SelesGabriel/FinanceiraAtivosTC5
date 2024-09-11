using AtivosTC5.Application.Services;
using AtivosTC5.Domain.Entities;
using AtivosTC5.Domain.Interfaces.Services;
using AtivosTC5.Domain.Models.Requests;
using AtivosTC5.Domain.Models.Responses;
using Moq;
using Xunit;

namespace AtivosTC5.Tests.Application.Services
{
    public class UsuarioAppServiceTests
    {
        private readonly Mock<IUsuarioDomainService> _mockUsuarioDomainService;
        private readonly UsuarioAppService _usuarioAppService;

        public UsuarioAppServiceTests()
        {
            _mockUsuarioDomainService = new Mock<IUsuarioDomainService>();
            _usuarioAppService = new UsuarioAppService(_mockUsuarioDomainService.Object);
        }

        [Fact]
        public void CriarConta_ValidaUsuario_CriaContaComSucesso()
        {
            // Arrange
            var requestModel = new CriarContaRequestModel
            {
                Nome = "Teste Usuario",
                Email = "teste@usuario.com",
                Senha = "senha123"
            };

            var usuario = new Usuario
            {
                Id = 1,
                Nome = requestModel.Nome,
                Email = requestModel.Email,
                Senha = requestModel.Senha
            };

            _mockUsuarioDomainService.Setup(s => s.CriarConta(It.IsAny<Usuario>())).Verifiable();

            // Act
            var result = _usuarioAppService.CriarConta(requestModel);

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Parabéns! Sua conta de usuário foi criada com sucesso.", result.Mensagem);
            Assert.Equal(requestModel.Nome, result.Nome);
            Assert.Equal(requestModel.Email, result.Email);
            _mockUsuarioDomainService.Verify(s => s.CriarConta(It.Is<Usuario>(u => u.Nome == requestModel.Nome &&
                                                                                  u.Email == requestModel.Email)), Times.Once);
        }

        [Fact]
        public void Autenticar_UsuarioValido_RetornaRespostaComSucesso()
        {
            // Arrange
            var requestModel = new AutenticarRequestModel
            {
                Email = "teste@usuario.com",
                Senha = "senha123"
            };

            var usuario = new Usuario
            {
                Id = 1,
                Nome = "Teste Usuario",
                Email = requestModel.Email,
                AccessToken = "token_jwt"
            };

            _mockUsuarioDomainService.Setup(s => s.Autenticar(requestModel.Email, requestModel.Senha)).Returns(usuario);

            // Act
            var result = _usuarioAppService.Autenticar(requestModel);

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Autenticação realizada com sucesso.", result.Mensagem);
            Assert.Equal(usuario.Id, result.Id);
            Assert.Equal(usuario.Nome, result.Nome);
            Assert.Equal(usuario.Email, result.Email);
            Assert.Equal(usuario.AccessToken, result.AccessToken);
        }

        [Fact]
        public void Autenticar_UsuarioInvalido_LançaExceção()
        {
            // Arrange
            var requestModel = new AutenticarRequestModel
            {
                Email = "teste@usuario.com",
                Senha = "senha123"
            };

            _mockUsuarioDomainService.Setup(s => s.Autenticar(requestModel.Email, requestModel.Senha)).Throws(new Exception("Usuário não encontrado."));

            // Act & Assert
            Assert.Throws<Exception>(() => _usuarioAppService.Autenticar(requestModel));
        }
    }
}
