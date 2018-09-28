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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Behaviours;


namespace _0DayAdmin
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void btningresar_Click(object sender, RoutedEventArgs e)
        {

            if (txtusuario.Text == "admin" && pbcontraseña.Password == "123")
            {
                await this.ShowMessageAsync("Exito", "Tus datos son correctos");
                Menu _ver = new Menu();
                this.Close();
                _ver.ShowDialog();
            }
            else
            {
                await this.ShowMessageAsync("Error!", "Verifica tus datos");
            }
        }
    }
}
