using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Behaviours;

namespace _0DayAdmin
{
    /// <summary>
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class Menu : MetroWindow
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Tile_Click_1(object sender, RoutedEventArgs e)
        {
            flyprueba.IsOpen = true;
        }

        private void Tile_Click(object sender, RoutedEventArgs e)
        {

        }

        private async void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            await this.ShowMessageAsync("No te pierdas el siguiente tutorial :D", "Por favor no olvides suscribirte y darle like si te ha gustado el video...");

        }
    }
}
