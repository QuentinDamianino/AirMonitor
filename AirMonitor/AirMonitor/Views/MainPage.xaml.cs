using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AirMonitor.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void Help_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Co to jest CAQI", "CAQI jest liczbą w skali od 1 do 100, gdzie niska wartość oznacza dobrą jakość powietrza oraz wysoka wartość oznacza złą jakość powietrza.", "Zamknij");
        }
    }
}
