//Nome e prontuário da dupla:
//Lucas da Silva Santos CB3030598
//Kaueh Farias Ferreira dos Santos CB3031438

using Microsoft.Extensions.DependencyInjection;
using TP03_Rastreamento.Views;

namespace TP03_Rastreamento
{
    public partial class App : Application
    {
        public App(IServiceProvider serviceProvider)
        {
            InitializeComponent();

            MainPage = new NavigationPage(
                serviceProvider.GetRequiredService<BuscaPage>());
        }
    }
}