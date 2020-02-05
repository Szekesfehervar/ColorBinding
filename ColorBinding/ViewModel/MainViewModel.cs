using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;

namespace ColorBinding.ViewModel
{
    class MainViewModel : INotifyPropertyChanged
    {
        private double _red;
        private double _green;
        private double _blue;
        private SolidColorBrush _selectedcolor;

        public MainViewModel()
        {
            Red = 100;
            Green = 50;
            Blue = 10;
        }

        public double Red { get { return _red; } set { _red = value; NotifyPropertyChanged(); } }
        public double Green { get { return _green; } set { _blue = value; NotifyPropertyChanged(); } }  
        public double Blue  { get { return _blue;  } set {_blue = value; NotifyPropertyChanged(); } }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }


    }
}
