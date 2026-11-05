//Nome e prontuário da dupla:
//Lucas da Silva Santos CB3030598
//Kaueh Farias Ferreira dos Santos CB3031438

using TP03_Rastreamento.ViewModels;

namespace TP03_Rastreamento.Views
{
    public partial class ResultadoPage : ContentPage
    {
        public ResultadoPage(RastreamentoViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = viewModel;
        }
    }
}