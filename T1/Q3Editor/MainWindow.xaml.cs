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
using Microsoft.Win32;
using System.IO;

namespace Q3Editor
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool guardado = true;
        private MessageBoxResult ComfirmacionBox(string texto)
        {
            return MessageBox.Show(texto, "Confirmación", MessageBoxButton.YesNo, MessageBoxImage.Question);
        }
        private void SeGuarda()
        {
            if(txtTexto.Text != "" && !guardado)
            {
                if(ComfirmacionBox("¿Desea guardar el texto?") == MessageBoxResult.Yes)
                {
                    Guardar();
                }
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            guardado = true;
            RoutedCommand Ctrl_N = new RoutedCommand();
            Ctrl_N.InputGestures.Add(new KeyGesture(Key.N, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(Ctrl_N, mArchivoNuevo_Click));
            
            RoutedCommand Ctrl_O = new RoutedCommand();
            Ctrl_O.InputGestures.Add(new KeyGesture(Key.O, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(Ctrl_O, mArchivoNuevo_Click));

            RoutedCommand Ctrl_S = new RoutedCommand();
            Ctrl_S.InputGestures.Add(new KeyGesture(Key.S, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(Ctrl_S, mArchivoNuevo_Click));

            RoutedCommand Alt_F4 = new RoutedCommand();
            Alt_F4.InputGestures.Add(new KeyGesture(Key.F4, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(Alt_F4, mArchivoNuevo_Click));

            txtTexto.Focus();
        }

        private void mArchivoSalir_Click(object sender, RoutedEventArgs e)
        {
            GuardarComo();
            Close();
        }

        private void mArchivoNuevo_Click(object sender, RoutedEventArgs e)
        {
            Guardar();
            txtTexto.Clear();
        }
        
        private void mArchivoAbrir_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);

            openFileDialog.InitialDirectory = path;
            openFileDialog.Filter = "txt files(*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            // Si pulsamos abrir... del menu abrir
            if (openFileDialog.ShowDialog() == true)
            {
                // Declaro una variable de tipo fichero
                var fileStream = openFileDialog.OpenFile();

                // Creo un canal de lectura (Objeto StreamReader Instanciado)
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    // Rellenamos el TextBox con el contenido del fichero
                    txtTexto.Text = reader.ReadToEnd();
                }
                //Alternativa simple.
                //txtTexto.Text = File.ReadAllText(openFileDialog.FileName);

                // En la barra de estado pongo el nombre del fichero
                panelNombre.Content = openFileDialog.FileName;

                // Y indico que esta guardado
                guardado = true;
                panelEstado.Content = "Guardado";
            }
        }
        private void Guardar()
        {
            // Si no esta guardado...
            if (!guardado)
            {
                // Si no tiene nombre
                if (panelNombre.Content.ToString() == "Sin Nombre")
                {
                    GuardarComo();
                }
                else
                {
                    // Lo guardamos en el fichero
                    File.WriteAllText(panelNombre.Content.ToString(), txtTexto.Text);

                    // Se ha gurdado el texto
                    guardado = true;

                    // Indicamos que se ha guardado
                    panelEstado.Content = "Guardado";
                }
            }
        }

        private void mArchivoGuardar_Click(object sender, RoutedEventArgs e)
        {
            Guardar();
        }
        private void GuardarComo()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.InitialDirectory = "D:\\";
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = false;

            if (saveFileDialog.ShowDialog() == true)
            {
                // Indicamos el nombre
                panelNombre.Content = saveFileDialog.FileName;

                // Lo guardamos en el fichero
                File.WriteAllText(panelNombre.Content.ToString(), txtTexto.Text);

                // Se ha guardado el texto
                guardado = true;

                // Indicamos que se ha guardado
                panelEstado.Content = "Guardado";
            }
        }
        private void mArchivoGuardarComo_Click(object sender, RoutedEventArgs e)
        {
            GuardarComo();   
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SeGuarda();
        }

        private void txtTexto_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(guardado == true)
            {
                // Cada vez que cambie el contenido del texto indicaremos que hay que guardarlo
                guardado = false;

                panelEstado.Content = "No Guardado";
            }
        }
    }
}
