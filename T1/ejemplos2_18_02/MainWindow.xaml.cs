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

namespace ejemplos2_18_02
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void mEditarReemplazar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void mEditarBuscar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void mArchivoSalir_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void mArchivoGuardar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Guargdado");
        }

        private void mArchivoNuevo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Abriendo proyecto");
        }

        private void mItem1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Has pulsado Item1");
        }

        private void mItem2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Has pulsado Item2");
        }

        private void mItem3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Has pulsado Item3");
        }

        private void btnFacturar_Click(object sender, RoutedEventArgs e)
        {
            int registros = 50000;
            pbFacturacion.Maximum = registros;
            pbFacturacion.Minimum = 0;
            pbFacturacion.Value = 0;

            for (int i = 0; i < registros; i++)
            {
               pbFacturacion.Value++;
            }
        }
    }
}
