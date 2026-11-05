//Nome e prontuário da dupla:
//Lucas da Silva Santos CB3030598
//Kaueh Farias Ferreira dos Santos CB3031438

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP03_Rastreamento.Commands;
using TP03_Rastreamento.Models;
using TP03_Rastreamento.Services;

namespace TP03_Rastreamento.ViewModels
{
    public class RastreamentoViewModel : BaseViewModel
    {
        private readonly IRastreamentoService _rastreamentoService;
        private readonly INavigationService _navigationService;

        private string _codigoRastreamento = string.Empty;
        private string _mensagemErro = string.Empty;
        private bool _isBusy;
        private Pacote? _pacote;

        public AsyncCommand BuscarCommand { get; }

        public AsyncCommand VoltarCommand { get; }

        public string CodigoRastreamento
        {
            get => _codigoRastreamento;
            set => SetProperty(ref _codigoRastreamento, value);
        }

        public string MensagemErro
        {
            get => _mensagemErro;
            set => SetProperty(ref _mensagemErro, value);
        }

        public bool IsBusy
        {
            get => _isBusy;
            set => SetProperty(ref _isBusy, value);
        }

        public Pacote? Pacote
        {
            get => _pacote;
            set => SetProperty(ref _pacote, value);
        }

        public RastreamentoViewModel(
            IRastreamentoService rastreamentoService,
            INavigationService navigationService)
        {
            _rastreamentoService = rastreamentoService;
            _navigationService = navigationService;

            BuscarCommand = new AsyncCommand(BuscarAsync);
            VoltarCommand = new AsyncCommand(VoltarAsync);
        }

        private async Task BuscarAsync()
        {
            MensagemErro = string.Empty;

            if (string.IsNullOrWhiteSpace(CodigoRastreamento))
            {
                MensagemErro = "Digite um código de rastreamento.";
                return;
            }

            IsBusy = true;

            try
            {
                Pacote = await _rastreamentoService.BuscarPacoteAsync(
                    CodigoRastreamento.Trim());

                if (Pacote == null)
                {
                    MensagemErro = "Nenhum pacote encontrado para esse código.";
                    return;
                }

                await _navigationService.IrParaResultadoAsync();
            }
            catch (Exception)
            {
                MensagemErro = "Não foi possível realizar a consulta.";
            }
            finally
            {
                IsBusy = false;
            }
        }

        private async Task VoltarAsync()
        {
            await _navigationService.VoltarAsync();
        }
    }
}
