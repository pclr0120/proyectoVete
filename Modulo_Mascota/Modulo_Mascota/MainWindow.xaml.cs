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

namespace Modulo_Mascota
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

        private void button_Click(object sender, RoutedEventArgs e)
        {

            Mascota pMascota = new Mascota();
            pMascota.idCliente = Int32.Parse(txtCliente.Text.Trim());
            pMascota.nombre = txtNombre.Text.Trim();
            pMascota.especie = txtEspecie.Text.Trim();
            pMascota.raza = txtRaza.Text.Trim();
            pMascota.color = txtColor.Text.Trim();
            pMascota.peso = txtPeso.Text.Trim();
            if (radioButton.IsChecked == true)
            {
                pMascota.sexo = "M";
            }
            else
            {
                pMascota.sexo = "H";
            }
            pMascota.senasParticulares = txtSparti.Text.Trim();
            pMascota.fechaNacimiento= dtpFechaNacimiento.SelectedDate.Value.Year + "/" + dtpFechaNacimiento.SelectedDate.Value.Month + "/" + dtpFechaNacimiento.SelectedDate.Value.Day;
            pMascota.statuss = "A";

            int resultado = MascotaDal.InvocarSP(pMascota);
            if (resultado > 0)
            {
                MessageBox.Show("Mascota Guardado Con Exito!!", "Guardado");
            }
            else
            {
                MessageBox.Show("No se pudo guardar el cliente", "Fallo!!");
            }

        }

        private void radioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {   
            this.Close();
        }
    }
}
