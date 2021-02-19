// --------------------------------------------
// Miguel
// Curso DAM
// Modalidad Presencial
// Práctica nº 3
// --------------------------------------------



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
using System.Text.RegularExpressions;




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
            Close();
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
            if (System.Text.RegularExpressions.Regex.IsMatch(txtTelefono1.Text, "[^0-9]"))
            {
                MessageBox.Show("Introduzca numeros unicamente.");
                txtTelefono1.Text = txtTelefono1.Text.Remove(txtTelefono1.Text.Length - 1);
            }
        }

        private void txtTelefono2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtTelefono2.Text, "[^0-9]"))
            {
                MessageBox.Show("Introduzca numeros unicamente.");
                txtTelefono2.Text = txtTelefono2.Text.Remove(txtTelefono2.Text.Length - 1);
            }
            if (txtTelefono2.Text != "")
            {
                txtTelefono2.Background = Brushes.White;
            }
            else
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#FFB7E4E2");
                txtTelefono2.Background = brush;
            }
        }

        private void txtPoblacion_TextChanged(object sender, TextChangedEventArgs e)
        {
           
            if (txtPoblacion.Text != "")
            {
                txtPoblacion.Background = Brushes.White;
            }
            else
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#FFE68080");
                txtPoblacion.Background = brush;
            }
        }

        private void rdCliente_Checked(object sender, RoutedEventArgs e)
        {
            
            cbProvincia.IsEnabled = true;
            cbProvincia.Items.Clear();
            cbProvincia.Items.Add("Castellón");
            cbProvincia.Items.Add("Valencia");
            cbProvincia.Items.Add("Alicante");
            cbProvincia.Items.Add("Murcia");
            cbProvincia.Items.Add("Albacete");
            cbProvincia.Items.Add("Cuenca");
            cbProvincia.Items.Add("Teruel");
        }

        private void rdDistribuidor_Checked(object sender, RoutedEventArgs e)
        {
            
            cbProvincia.IsEnabled = true;
            cbProvincia.Items.Clear();
            cbProvincia.Items.Add("Castellón");
            cbProvincia.Items.Add("Valencia");
            cbProvincia.Items.Add("Alicante");
        }

        private void txtCorreo_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            if (txtCorreo.Text != "")
            {
                txtCorreo.Background = Brushes.White;
            }
            else
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#FFE68080");
                txtCorreo.Background = brush;
            }
        }

        private void txtApellido2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtApellido2.Text != "")
            {
                txtApellido2.Background = Brushes.White;
            }
            else
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#FFB7E4E2");
                txtApellido2.Background = brush;
            }
        }

        private void txtDireccion_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            if (txtDireccion.Text != "")
            {
                txtDireccion.Background = Brushes.White;
            }
            else
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#FFE68080");
                txtDireccion.Background = brush;
            }
        }

        private void txtCp_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            if (txtCp.Text != "")
            {
                txtCp.Background = Brushes.White;
            }
            else
            {
                var converter = new System.Windows.Media.BrushConverter();
                var brush = (Brush)converter.ConvertFromString("#FFE68080");
                txtCp.Background = brush;
            }
        }

        private void BtnEnviar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("");
            /*
            if (rdCliente.IsChecked) 
            { 
                MessageBox.Show("INSERT INTO clientes(....) VALUES(...)"); 
            }
            else
            {
                MessageBox.Show("INSERT INTO distribuidores(...) VALUES(...)");
            }
            */

        }

        private void BtnEnviar_LayoutUpdated(object sender, EventArgs e)
        {
            BtnEnviar.IsEnabled = !string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtApellido1.Text)
                && !string.IsNullOrEmpty(txtTelefono1.Text) && !string.IsNullOrEmpty(txtPoblacion.Text)
                && !string.IsNullOrEmpty(txtCorreo.Text) && !string.IsNullOrEmpty(txtDireccion.Text)
                && !string.IsNullOrEmpty(txtCp.Text) && !string.IsNullOrEmpty(cbProvincia.Text);
        }

    }   
}
