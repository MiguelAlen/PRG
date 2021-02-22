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

namespace Q3Editor
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool guardado = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void mArchivoSalir_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void mArchivoNuevo_Click(object sender, RoutedEventArgs e)
        {
            Guardar();
            txtMain.Clear();
        }
        private void Guardar()
        {
            if (txtMain.Text != "" && !guardado)
            {
                if (MessageBox.Show("¿Quiere guardar el contenido?", 
                                                    "Confirmación.",
                                                    MessageBoxButton.YesNo,
                                                    MessageBoxImage.Question)
                        == MessageBoxResult.Yes)
                {
                    MessageBox.Show("Guardando...");
                    guardado = true;
                }
            }
        }
    }
}
