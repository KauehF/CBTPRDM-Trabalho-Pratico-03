//Nome e prontuário da dupla:
//Lucas da Silva Santos CB3030598
//Kaueh Farias Ferreira dos Santos CB3031438

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using TP03_Rastreamento.Views;

namespace TP03_Rastreamento.Services
{
    public class NavigationService : INavigationService
    {
        private readonly IServiceProvider _serviceProvider;

        public NavigationService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        private NavigationPage ObterNavigationPage()
        {
            NavigationPage pagina = Application.Current?.Windows.FirstOrDefault()?.Page as NavigationPage;

            if (pagina == null)
            {
                throw new InvalidOperationException(
                    "A página de navegação não foi encontrada.");
            }

            return pagina;
        }

        public async Task IrParaResultadoAsync()
        {
            NavigationPage pagina = ObterNavigationPage();

            await pagina.Navigation.PushAsync(
                _serviceProvider.GetRequiredService<ResultadoPage>());
        }

        public async Task VoltarAsync()
        {
            NavigationPage pagina = ObterNavigationPage();

            await pagina.Navigation.PopAsync();
        }
    }
}