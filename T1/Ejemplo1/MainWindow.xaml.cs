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
            //if(cbEstudias.IsChecked == true)
            Close();
        }
        /*private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
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
        }*/

        private void rdVehiculoSI_Checked(object sender, RoutedEventArgs e)
        {
            cbTipoVehiculo.IsEnabled = true;
        }

        private void rdVehiculoNo_Checked(object sender, RoutedEventArgs e)
        {
            cbTipoVehiculo.SelectedIndex = -1;
            cbTipoVehiculo.IsEnabled = false;
        }

        private void txtNombre_GotFocus(object sender, RoutedEventArgs e)
        {
           
        }

        private void txtNombre_TextChanged(object sender, TextChangedEventArgs e)
        {
            

            if (txtNombre.Text != "") 
            {
                txtNombre.Background = Brushes.White; 
            }
            else 
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#FFE68080");
                txtNombre.Background = brush; 
            }
        }

        private void txtApellido1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtApellido1.Text != "")
            {
                txtApellido1.Background = Brushes.White;
            }
            else
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#FFE68080");
                txtApellido1.Background = brush;
            }
        }

        private void txtTelefono1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtTelefono1.Text != "")
            {
                txtTelefono1.Background = Brushes.White;
            }
            else
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#FFE68080");
                txtTelefono1.Background = brush;
            }
        }

        private void txtTelefono2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtTelefono2.Text != "")
            {
                txtTelefono2.Background = Brushes.White;
            }
            else
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#FFE68080");
                txtTelefono2.Background = brush;
            }
        }
    }   
}
