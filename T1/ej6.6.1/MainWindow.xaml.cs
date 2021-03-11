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
        Persona[] persona;
        int i;
        public MainWindow()
        {
            InitializeComponent();
            i = 0;
            // arrays tipo clase especifica 
            persona = new Persona[10];           
        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            if (pbPersona.Value == 10) { MessageBox.Show("No queda espacio"); }
            else
            {
                // constructor parametrizado -> inicializar el objeto (parametros)
                if (txtPersona.Equals("") == false)
                {
                    persona[i] = new Persona();
                    persona[i].SetNombre(txtPersona.Text);
                    persona[i].id = i;
                    i++;
                    pbPersona.Value++;
                    //cbPersona.Items.Insert(i, persona[i]);
                    cbPersona.Items.Add(persona[i].nombre);
                }
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            txtPersona.Text = "";
        }

    }
}
