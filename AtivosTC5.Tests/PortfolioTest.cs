using AtivosTC5.Application.Services;
using AtivosTC5.Domain.Entities;
using AtivosTC5.Domain.Interfaces.Services;
using AtivosTC5.Domain.Models;
using AtivosTC5.Domain.ValueObjects;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace AtivosTC5.Application.Tests.Services
{
    public class PortfolioAppServiceTests
    {
        private readonly Mock<IPortfolioDomainService> _mockDomainService;
        private readonly PortfolioAppService _portfolioAppService;

        public PortfolioAppServiceTests()
        {
            _mockDomainService = new Mock<IPortfolioDomainService>();
            _portfolioAppService = new PortfolioAppService(_mockDomainService.Object);
        }

        [Fact]
        public async Task GetPortfolioPorId_ValidId_ReturnsPortfolioResponseModel()
        {
            // Arrange
            var portfolioId = 1;
            var portfolio = new Portfolio
            {
                Id = portfolioId,
                Descricao = "Meu Portfolio",
                Usuario_Id = 123,
                portfolioAtivos = new List<PortfolioAtivo>
                {
                    new PortfolioAtivo
                    {
                        Ativo_Id = 1,
                        Quantidade = 10,
                        ativo = new Ativo
                        {
                            Sigla = "AAPL",
                            ativoTipo = new AtivoTipo { Id = 1, Nome = "Ação" }
                        }
                    }
                }
            };

            _mockDomainService.Setup(x => x.ObterPorid(portfolioId)).ReturnsAsync(portfolio);

            // Act
            var result = await _portfolioAppService.GetPortfolioPorId(portfolioId);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(portfolio.Descricao, result.Descricao);
            Assert.Equal(portfolio.Usuario_Id, result.Usuario_Id);
            Assert.Equal(portfolioId, result.Portifolio_Id);
            Assert.Single(result.Ativos);
            Assert.Equal("AAPL", result.Ativos.First().Sigla);
        }

        [Fact]
        public async Task GetPortfolioPorId_InvalidId_ThrowsException()
        {
            // Arrange
            var portfolioId = 1;
            _mockDomainService.Setup(x => x.ObterPorid(portfolioId)).ReturnsAsync((Portfolio)null);

            // Act & Assert
            var exception = await Assert.ThrowsAsync<Exception>(() => _portfolioAppService.GetPortfolioPorId(portfolioId));
            Assert.Equal("Portfolio Não Cadastrado", exception.Message);
        }

        [Fact]
        public async Task GetPortfolioPorIdUsuario_ValidUserId_ReturnsPortfolioResponseModels()
        {
            // Arrange
            var userId = 123;
            var portfolios = new List<Portfolio>
            {
                new Portfolio
                {
                    Id = 1,
                    Descricao = "Portfolio 1",
                    Usuario_Id = userId,
                    portfolioAtivos = new List<PortfolioAtivo>
                    {
                        new PortfolioAtivo
                        {
                            Ativo_Id = 1,
                            Quantidade = 10,
                            ativo = new Ativo
                            {
                                Sigla = "AAPL",
                                ativoTipo = new AtivoTipo { Id = 1, Nome = "Ação" }
                            }
                        }
                    }
                }
            };

            _mockDomainService.Setup(x => x.ObterPoridUsuario(userId)).ReturnsAsync(portfolios);

            // Act
            var result = await _portfolioAppService.GetPortfolioPorIdUsuario(userId);

            // Assert
            Assert.NotNull(result);
            Assert.Single(result);
            Assert.Equal(portfolios.First().Descricao, result.First().Descricao);
        }

        [Fact]
        public async Task GetPortfolioPorIdUsuario_InvalidUserId_ThrowsException()
        {
            // Arrange
            var userId = 123;
            _mockDomainService.Setup(x => x.ObterPoridUsuario(userId)).ReturnsAsync((List<Portfolio>)null);

            // Act & Assert
            var exception = await Assert.ThrowsAsync<Exception>(() => _portfolioAppService.GetPortfolioPorIdUsuario(userId));
            Assert.Equal("Portfolio Não Cadastrado", exception.Message);
        }

        [Fact]
        public async Task PostPortfolio_ValidModel_ReturnsSuccessMessage()
        {
            // Arrange
            var portfolio = new Portfolio { Descricao = "Novo Portfolio", Usuario_Id = 123 };
            var expectedResponse = "Portfolio gravado com sucesso";
            _mockDomainService.Setup(x => x.GravaPortfolio(portfolio)).ReturnsAsync(expectedResponse);

            // Act
            var result = await _portfolioAppService.PostPortfolio(portfolio);

            // Assert
            Assert.Equal(expectedResponse, result);
        }
    }
}
