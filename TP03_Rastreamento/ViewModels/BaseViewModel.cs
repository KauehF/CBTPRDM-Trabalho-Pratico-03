//Nome e prontuário da dupla:
//Lucas da Silva Santos CB3030598
//Kaueh Farias Ferreira dos Santos CB3031438

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TP03_Rastreamento.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(
            [CallerMemberName] string nomePropriedade = "")
        {
            PropertyChanged?.Invoke(
                this,
                new PropertyChangedEventArgs(nomePropriedade));
        }

        protected bool SetProperty<T>(
            ref T campo,
            T valor,
            [CallerMemberName] string nomePropriedade = "")
        {
            if (EqualityComparer<T>.Default.Equals(campo, valor))
            {
                return false;
            }

            campo = valor;

            OnPropertyChanged(nomePropriedade);

            return true;
        }
    }
}
