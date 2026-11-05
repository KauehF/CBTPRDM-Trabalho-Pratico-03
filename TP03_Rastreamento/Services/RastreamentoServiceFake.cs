//Nome e prontuário da dupla:
//Lucas da Silva Santos CB3030598
//Kaueh Farias Ferreira dos Santos CB3031438

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using TP03_Rastreamento.Models;

namespace TP03_Rastreamento.Services
{
    public class RastreamentoServiceFake : IRastreamentoService
    {
        public async Task<Pacote?> BuscarPacoteAsync(string codigoRastreamento)
        {
            await Task.Delay(1500);

            switch (codigoRastreamento.ToUpper())
            {
                case "BR123456":
                    return new Pacote
                    {
                        Id = 1,
                        CodigoRastreamento = "BR123456",
                        Status = "Em trânsito",
                        DataEnvio = new DateTime(2026, 10, 28),
                        DataPrevistaEntrega = new DateTime(2026, 11, 5),
                        LocalizacaoAtual = "Centro de Distribuição - Santos/SP",

                        HistoricoEventos = new ObservableCollection<EventoRastreamento>
                        {
                            new EventoRastreamento
                            {
                                DataHora = new DateTime(2026, 11, 1, 14, 30, 0),
                                Local = "Santos/SP",
                                Descricao = "Pacote encaminhado para o centro de distribuição."
                            },
                            new EventoRastreamento
                            {
                                DataHora = new DateTime(2026, 10, 30, 10, 15, 0),
                                Local = "São Paulo/SP",
                                Descricao = "Pacote chegou ao centro de distribuição."
                            },
                            new EventoRastreamento
                            {
                                DataHora = new DateTime(2026, 10, 28, 16, 0, 0),
                                Local = "São Paulo/SP",
                                Descricao = "Objeto postado."
                            }
                        }
                    };

                case "BR654321":
                    return new Pacote
                    {
                        Id = 2,
                        CodigoRastreamento = "BR654321",
                        Status = "Saiu para entrega",
                        DataEnvio = new DateTime(2026, 10, 25),
                        DataPrevistaEntrega = new DateTime(2026, 11, 2),
                        LocalizacaoAtual = "Unidade de Distribuição - Cubatão/SP",

                        HistoricoEventos = new ObservableCollection<EventoRastreamento>
                        {
                            new EventoRastreamento
                            {
                                DataHora = new DateTime(2026, 11, 1, 8, 30, 0),
                                Local = "Cubatão/SP",
                                Descricao = "Objeto saiu para entrega ao destinatário."
                            },
                            new EventoRastreamento
                            {
                                DataHora = new DateTime(2026, 10, 30, 12, 0, 0),
                                Local = "Santos/SP",
                                Descricao = "Objeto chegou à unidade de distribuição."
                            },
                            new EventoRastreamento
                            {
                                DataHora = new DateTime(2026, 10, 25, 9, 0, 0),
                                Local = "São Paulo/SP",
                                Descricao = "Objeto postado."
                            }
                        }
                    };

                case "BR987654":
                    return new Pacote
                    {
                        Id = 3,
                        CodigoRastreamento = "BR987654",
                        Status = "Entregue",
                        DataEnvio = new DateTime(2026, 10, 20),
                        DataPrevistaEntrega = new DateTime(2026, 10, 29),
                        LocalizacaoAtual = "Praia Grande/SP",

                        HistoricoEventos = new ObservableCollection<EventoRastreamento>
                        {
                            new EventoRastreamento
                            {
                                DataHora = new DateTime(2026, 10, 27, 15, 45, 0),
                                Local = "Praia Grande/SP",
                                Descricao = "Objeto entregue ao destinatário."
                            },
                            new EventoRastreamento
                            {
                                DataHora = new DateTime(2026, 10, 27, 8, 0, 0),
                                Local = "Praia Grande/SP",
                                Descricao = "Objeto saiu para entrega."
                            },
                            new EventoRastreamento
                            {
                                DataHora = new DateTime(2026, 10, 20, 11, 30, 0),
                                Local = "São Paulo/SP",
                                Descricao = "Objeto postado."
                            }
                        }
                    };

                default:
                    return null;
            }
        }
    }
}
