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
using System.IO;
using System.Windows.Forms;
using System.Drawing;

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
            return System.Windows.MessageBox.Show(texto, "Confirmación", MessageBoxButton.YesNo, MessageBoxImage.Question);
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

            RoutedCommand Ctrl_B = new RoutedCommand();
            Ctrl_B.InputGestures.Add(new KeyGesture(Key.B, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(Ctrl_B, mFuenteNegrita_Click));

            RoutedCommand Ctrl_K= new RoutedCommand();
            Ctrl_K.InputGestures.Add(new KeyGesture(Key.K, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(Ctrl_K, mFuenteCursiva_Click));

            RoutedCommand Ctrl_U = new RoutedCommand();
            Ctrl_U.InputGestures.Add(new KeyGesture(Key.U, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(Ctrl_U, mFuenteSubrayado_Click));

            RoutedCommand Ctrl_Mas = new RoutedCommand();
            Ctrl_Mas.InputGestures.Add(new KeyGesture(Key.Add, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(Ctrl_Mas, mFuenteAumentar_Click));
            
            RoutedCommand Ctrl_Menos = new RoutedCommand();
            Ctrl_Menos.InputGestures.Add(new KeyGesture(Key.Subtract, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(Ctrl_Menos, mFuenteDisminuir_Click));

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

            panelNombre.Content = "<Sin Nombre>";
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
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
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

            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
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

        private void mEditarCortar_Click(object sender, RoutedEventArgs e)
        {
            if(txtTexto.SelectedText != "")
            {
                txtTexto.Cut();
            }
        }

        private void mEditarCopiar_Click(object sender, RoutedEventArgs e)
        {
            if (txtTexto.SelectionLength > 0)
            {
                txtTexto.Copy();
            }
        }

        private void mEditarPegar_Click(object sender, RoutedEventArgs e)
        {
            txtTexto.Paste();
        }

        private void mFuenteNegrita_Click(object sender, RoutedEventArgs e)
        {
            if (mFuenteNegrita.IsChecked)
            {
                txtTexto.FontWeight = FontWeights.Normal;
                mFuenteNegrita.IsChecked = false;
            }
            else
            {
                txtTexto.FontWeight = FontWeights.Bold;
                mFuenteNegrita.IsChecked = true;
            }
        }

        private void mFuenteCursiva_Click(object sender, RoutedEventArgs e)
        {
            if (mFuenteCursiva.IsChecked)
            {
                txtTexto.FontStyle = FontStyles.Normal;
                mFuenteCursiva.IsChecked = false;
            }
            else
            {
                txtTexto.FontStyle = FontStyles.Italic;
                mFuenteCursiva.IsChecked = true;
            }
        }

        private void mFuenteSubrayado_Click(object sender, RoutedEventArgs e)
        {
            if (mFuenteSubrayado.IsChecked)
            {
                txtTexto.TextDecorations = null;
                mFuenteSubrayado.IsChecked = false;
            }
            else
            {
                txtTexto.TextDecorations = TextDecorations.Underline;
                mFuenteSubrayado.IsChecked = true;
            }
        }

        private void mFuenteAumentar_Click(object sender, RoutedEventArgs e)
        {
            txtTexto.FontSize++;
        }

        private void mFuenteDisminuir_Click(object sender, RoutedEventArgs e)
        {
            if(txtTexto.FontSize > 1)
            {
                txtTexto.FontSize--;
            }
        }

        private void mFuenteFuentes_Click(object sender, RoutedEventArgs e)
        {
            FontDialog dlg = new FontDialog();
            dlg.ShowDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fontName;
                float fontSize;
                fontName = dlg.Font.Name;
                fontSize = dlg.Font.Size;
                System.Windows.MessageBox.Show(fontName + "    " + fontSize);
            }
        }
    }
}
