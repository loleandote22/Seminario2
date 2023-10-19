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

namespace Seminario2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void lblRecordarContraseña_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
           
        }   

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            imgAvatar.Source = new BitmapImage(new Uri("/imagenes/avatar2.jpg", UriKind.Relative));
            lblEstado.Content = "Entrando en avatar y cambiando imagen";
            lblEstado.Foreground = Brushes.Black;
        }

        private void imgAvatar_MouseLeave(object sender, MouseEventArgs e)
        {
            imgAvatar.Source = new BitmapImage(new Uri("/imagenes/avatar1.jpg", UriKind.Relative));
            lblEstado.Content = "Saliendo del avatar y recuperando imagen";
            lblEstado.Foreground = Brushes.Black;
        }

        private void Grid_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Point p = e.GetPosition(this);
            lblEstado.Content = "Coordenadas pulsadas (" + p.X + " + " + p.Y + ")";
            lblEstado.BorderBrush = Brushes.Black;
        }

        private void pbxContraseña_KeyUp(object sender, KeyEventArgs e)
        {
            lblEstado.Content="Letra pulsada <<"+e.Key.ToString()+">>";
            lblEstado.BorderBrush= Brushes.Black;
        }

        private void btLogin_Click(object sender, RoutedEventArgs e)
        {
            string usuario = "lole";
            if (!string.IsNullOrEmpty(tbxEmail.Text) && tbxEmail.Text.Equals(usuario, StringComparison.InvariantCultureIgnoreCase))
            {
                pbxContraseña.IsEnabled = true;
                tbxEmail.BorderBrush = Brushes.Transparent;
            }
            else
            {
                tbxEmail.BorderBrush = Brushes.Red;
                tbxEmail.BorderThickness = new Thickness(2);
                if (pbxContraseña.IsEnabled)
                {

                }
            }
           
        }
    }
}
