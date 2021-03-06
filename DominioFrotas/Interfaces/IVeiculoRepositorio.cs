﻿using DominioFrotas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioFrotas.Interfaces
{
    public interface IVeiculoRepositorio : IRepositorioBase<Veiculo>
    {
        IEnumerable<Veiculo> Listar(string filtro);
        Veiculo ListarPorChassi(string chassi);
    }
}
