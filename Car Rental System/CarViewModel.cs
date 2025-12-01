using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CarRentalSystem.Main
{
    public class CarViewModel : INotifyPropertyChanged
    {
        private string _model = string.Empty;
        private decimal _pricePerDay;
        private string _color = string.Empty;
        public string Model
        {
            get => _model;
            set
            {
                if (_model != value)
                {
                    _model = value;
                    OnPropertyChanged();
                }
            }
        }
        public decimal PricePerDay
        {
            get => _pricePerDay;
            set
            {
                if (_pricePerDay != value)
                {
                    _pricePerDay = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Color
        {
            get => _color;
            set
            {
                if (_color != value)
                {
                    _color = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}