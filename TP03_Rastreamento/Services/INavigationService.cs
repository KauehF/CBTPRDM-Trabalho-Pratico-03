//Nome e prontuário da dupla:
//Lucas da Silva Santos CB3030598
//Kaueh Farias Ferreira dos Santos CB3031438

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP03_Rastreamento.Services
{
    public interface INavigationService
    {
        Task IrParaResultadoAsync();

        Task VoltarAsync();
    }
}
