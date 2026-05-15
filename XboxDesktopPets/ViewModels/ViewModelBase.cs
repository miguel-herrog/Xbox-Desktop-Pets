using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace XboxDesktopPets.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        // El evento que avisa a la interfaz de que algo ha cambiado
        public event PropertyChangedEventHandler? PropertyChanged;

        // El método que dispara el aviso
        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}