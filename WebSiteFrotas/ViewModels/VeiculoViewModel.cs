using DominioFrotas.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebSiteFrotas.ViewModels
{
    public class VeiculoViewModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Chassi é obrigatório.")]
        [MaxLength(17, ErrorMessage = "O maximo são 17 digitos.")]
        [MinLength(17, ErrorMessage = "O minimo são 17 digitos.")]
        public string Chassi { get; set; }
        [Display(Name = "Tipo de veículo")]
        [Range(1, 2, ErrorMessage = "Campo Tipo é obrigatório.")]
        public TipoVeiculoView TipoVeiculo { get; set; }
        [Required(ErrorMessage = "Campo Cor é obrigatório.")]
        public string Cor { get; set; }

        [Display(Name = "Número de passageiros")]
        public byte NumeroPassageiros { get; set; }

        public VeiculoViewModel(Veiculo item)
        {
            Id = item.Id;
            Chassi = item.Chassi;
            TipoVeiculo =  (TipoVeiculoView)item.TipoVeiculo;
            Cor = item.Cor;
            NumeroPassageiros = item.NumeroPassageiros;
        }

        public Veiculo CriarVeiculo(string chassi, string cor, TipoVeiculoView tipo)
        {
            return new Veiculo(chassi, cor, (TipoVeiculo)tipo);
        }

        public Veiculo DominioMap()
        {
            return new Veiculo() { Id = this.Id, Chassi = this.Chassi, Cor = this.Cor, NumeroPassageiros = this.NumeroPassageiros, TipoVeiculo = (TipoVeiculo)this.TipoVeiculo };            
        }
        public VeiculoViewModel()
        {

        }

        public enum TipoVeiculoView
        {
            Caminhão = 1,
            Ônibus = 2
        }
    }
}