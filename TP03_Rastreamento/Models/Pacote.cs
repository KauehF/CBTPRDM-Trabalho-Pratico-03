//Nome e prontuário da dupla:
//Lucas da Silva Santos CB3030598
//Kaueh Farias Ferreira dos Santos CB3031438

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace TP03_Rastreamento.Models
{
    public class Pacote
    {
        public int Id { get; set; }

        public string CodigoRastreamento { get; set; } = string.Empty;

        public string Status { get; set; } = string.Empty;

        public DateTime DataEnvio { get; set; }

        public DateTime DataPrevistaEntrega { get; set; }

        public string LocalizacaoAtual { get; set; } = string.Empty;

        public ObservableCollection<EventoRastreamento> HistoricoEventos { get; set; }
    }
}
