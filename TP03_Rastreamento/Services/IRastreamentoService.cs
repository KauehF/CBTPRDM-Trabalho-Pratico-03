//Nome e prontuário da dupla:
//Lucas da Silva Santos CB3030598
//Kaueh Farias Ferreira dos Santos CB3031438

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP03_Rastreamento.Models;

namespace TP03_Rastreamento.Services
{
    public interface IRastreamentoService
    {
        Task<Pacote?> BuscarPacoteAsync(string codigoRastreamento);
    }
}
