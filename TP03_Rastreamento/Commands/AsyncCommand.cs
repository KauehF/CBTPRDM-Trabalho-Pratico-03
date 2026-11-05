using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TP03_Rastreamento.Commands
{
    public class AsyncCommand : ICommand
    {
        private readonly Func<Task> _executar;
        private bool _executando;

        public event EventHandler CanExecuteChanged;

        public AsyncCommand(Func<Task> executar)
        {
            _executar = executar;
        }

        public bool CanExecute(object parametro)
        {
            return !_executando;
        }

        public async void Execute(object parametro)
        {
            if (_executando)
            {
                return;
            }

            _executando = true;

            CanExecuteChanged?.Invoke(this, EventArgs.Empty);

            try
            {
                await _executar();
            }
            finally
            {
                _executando = false;

                CanExecuteChanged?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
