using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoColores
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // agregar una etiqueta dinamica
            Label lblSaludo = new Label()
            {
                Text = "Hola, soy claro y oscuro",
                FontSize = 24,
                TextColor = ((AppThemeColor)App.Current.Resources["frameTextColor"]).Value
            };

            fraContenedor.Content = lblSaludo;
        }
    }
}
