using AtivosTC5.Application.Services;
using AtivosTC5.Domain.Entities;
using AtivosTC5.Domain.Interfaces.Services;
using AtivosTC5.Domain.Models.Responses;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace AtivosTC5.Tests
{
    public class AtivoAppServiceTests
    {
        private readonly Mock<IAtivoDomainService> _mockDomainService;
        private readonly AtivoAppService _ativoAppService;

        public AtivoAppServiceTests()
        {
            _mockDomainService = new Mock<IAtivoDomainService>();
            _ativoAppService = new AtivoAppService(_mockDomainService.Object);
        }

        [Fact]
        public async Task ListaAtivos_DeveRetornarListaDeAtivoReponseModel_QuandoAtivosExistem()
        {
            // Arrange
            var ativos = new List<Ativo>
            {
                new Ativo
                {
                    Id = 1,
                    Sigla = "AT1",
                    Nome = "Ativo 1",
                    ativoTipo = new AtivoTipo { Id = 1, Nome = "Tipo 1" }
                },
                new Ativo
                {
                    Id = 2,
                    Sigla = "AT2",
                    Nome = "Ativo 2",
                    ativoTipo = new AtivoTipo { Id = 2, Nome = "Tipo 2" }
                }
            };

            _mockDomainService.Setup(ds => ds.ListaAtivos()).ReturnsAsync(ativos);

            // Act
            var result = await _ativoAppService.ListaAtivos();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count);
            Assert.Equal("AT1", result[0].Sigla);
            Assert.Equal("Ativo 1", result[0].Nome);
            Assert.Equal("Tipo 1", result[0].ativoTipo.Nome);
            Assert.Equal("AT2", result[1].Sigla);
            Assert.Equal("Ativo 2", result[1].Nome);
            Assert.Equal("Tipo 2", result[1].ativoTipo.Nome);
        }

        [Fact]
        public async Task ListaAtivos_DeveLancarException_QuandoOcorreErro()
        {
            // Arrange
            _mockDomainService.Setup(ds => ds.ListaAtivos()).ThrowsAsync(new Exception("Erro interno"));

            // Act & Assert
            await Assert.ThrowsAsync<Exception>(() => _ativoAppService.ListaAtivos());
        }
    }
}
