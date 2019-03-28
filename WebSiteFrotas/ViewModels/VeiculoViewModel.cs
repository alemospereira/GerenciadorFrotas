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
        public string Chassi { get; set; }
        [Required(ErrorMessage = "Campo Tipo é obrigatório.")]
        public int TipoVeiculo { get; set; }
        [Required(ErrorMessage = "Campo Cor é obrigatório.")]
        public string Cor { get; set; }

        public VeiculoViewModel(VeiculoBase item)
        {
            Id = item.Id;
            Chassi = item.Chassi;
            TipoVeiculo =  (int)item.TipoVeiculo;
            Cor = item.Cor;
        }
    }
}