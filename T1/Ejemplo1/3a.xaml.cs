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



namespace Ejemplo1
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

        private void BtnSalir_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Salir?",
                                        "Confirmación",
                                        MessageBoxButton.YesNo,
                                        MessageBoxImage.Question);

            if(result == MessageBoxResult.Yes)
            {
                MessageBox.Show("Chaooo " + TxtNombre.Text);
                Close();
            }
            
        }

        private void TxtNombre_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void TxtNombre_GotFocus_1(object sender, RoutedEventArgs e)
        {
            TxtNombre.Background = Brushes.White;
        }
    }
}
