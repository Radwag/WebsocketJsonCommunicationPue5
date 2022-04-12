using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SampleWinFormsApp.DataModels
{
    public abstract class PropViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}