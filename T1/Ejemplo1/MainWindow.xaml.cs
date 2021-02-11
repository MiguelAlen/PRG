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
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var result = MessageBox.Show("Salir?",
                                        "Confirmación",
                                        MessageBoxButton.YesNo,
                                        MessageBoxImage.Question);
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }

        private void BtnSalir_Click(object sender, RoutedEventArgs e)
        {
            
                if(cbEstudias.IsChecked == true)
               
                Close();
            
            
        }

        private void TxtNombre_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void TxtNombre_GotFocus_1(object sender, RoutedEventArgs e)
        {
            TxtNombre.Background = Brushes.White;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cbProvincias_DropDownClosed(object sender, EventArgs e)
        {
            MessageBox.Show(cbProvincias.Text +
                            " - SelectedIndex: "
                             + Convert.ToString(cbProvincias.SelectedIndex));
        }

        private void btProvincias_Click(object sender, RoutedEventArgs e)
        {
            if(cbProvincias.SelectedIndex == -1)
            {
                MessageBox.Show(cbProvincias.Text);
            }
        }

        private void rdVehiculoSI_Checked(object sender, RoutedEventArgs e)
        {
            cbTipoVehiculo.IsEnabled = true;
        }

        private void rdVehiculoNo_Checked(object sender, RoutedEventArgs e)
        {
            cbTipoVehiculo.SelectedIndex = -1;
            cbTipoVehiculo.IsEnabled = false;
        }
    }
}
