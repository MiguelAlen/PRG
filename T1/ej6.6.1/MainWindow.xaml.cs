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

namespace ej6._6._1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Persona> miPersona = new List<Persona>();
        int i;
        public MainWindow()
        {
            InitializeComponent();
            i = 0;
        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            if (txtPersona.Equals("") == false)
            {
                miPersona.Add(new Persona());
                miPersona[i].nombre = txtPersona.Text;
                miPersona[i].id = i;
                cbPersona.Items.Add(miPersona[i].nombre);
                cbPersona.SelectedIndex = i;
                i++;
            }
            
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            txtPersona.Text = "";
        }

    }
}
