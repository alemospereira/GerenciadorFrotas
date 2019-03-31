using System;
using AplicacaoFrotas.Aplicacoes;
using DominioFrotas.Entidades;
using DominioFrotas.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace TesteFrota
{
    [TestClass]
    public class VeiculoTeste
    {
        

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "Chassi já existe cadastrado!")]
        public void AdicinarErroInvalidOperation()
        {
            var item = new Veiculo
            {
                Chassi = "99999999999999999",
                TipoVeiculo = TipoVeiculo.Caminhao,
                Cor = "Branco"
            };

            var moq = new Mock<IVeiculoRepositorio>();
            var app = new VeiculoAplicacao(moq.Object);
            moq.Setup(x => x.ListarPorChassi(item.Chassi)).Returns(item);
            app.Adicionar(item);

            Assert.Fail();

        }

        [TestMethod]
        public void Adicionar()
        {
            var item = new Veiculo
            {
                Chassi = "99999999999999999",
                TipoVeiculo = TipoVeiculo.Caminhao,
                Cor = "Branco"
            };

            var moq = new Mock<IVeiculoRepositorio>();
            var app = new VeiculoAplicacao(moq.Object);
            app.Adicionar(item);

            moq.Verify(x => x.Adicionar(
                It.Is<Veiculo>(v => v.Chassi == item.Chassi)));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void RemoverErroNullReference()
        {
            var item = new Veiculo
            {
                Id = 1,
                Chassi = "99999999999999999",
                TipoVeiculo = TipoVeiculo.Caminhao,
                Cor = "Branco"
            };

            var moq = new Mock<IVeiculoRepositorio>();
            var app = new VeiculoAplicacao(moq.Object);
            moq.Setup(x => x.ListarPorId(item.Id)).Returns(It.IsAny<Veiculo>());
            app.Remover(item.Id);

            Assert.Fail();
        }

        [TestMethod]
        public void Remover()
        {
            var item = new Veiculo
            {
                Id = 1,
                Chassi = "99999999999999999",
                TipoVeiculo = TipoVeiculo.Caminhao,
                Cor = "Branco"
            };

            var moq = new Mock<IVeiculoRepositorio>();
            var app = new VeiculoAplicacao(moq.Object);
            moq.Setup(x => x.ListarPorId(item.Id)).Returns(item);
            app.Remover(item.Id);

            moq.Verify(x => x.Remover(
                It.Is<Veiculo>(v => v.Id == item.Id)));
        }
    }
}
