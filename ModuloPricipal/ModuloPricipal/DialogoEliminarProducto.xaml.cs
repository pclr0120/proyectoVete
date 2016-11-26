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
using System.Windows.Shapes;

namespace ModuloPricipal
{
    
    /// <summary>
    /// Lógica de interacción para DialogoEliminarProducto.xaml
    /// </summary>
    public partial class DialogoEliminarProducto : Window
    {
        public    DialogoEliminarProducto( )
        {

            InitializeComponent();
            txtRegistro.Focus();
            txtRegistro.Text = "";
           
        }

       

       
        public void numeroRegistro(object sender, KeyEventArgs e)
        {

            if (Key.F1 == e.Key && txtRegistro.Text!="" ) {

              
                this.Close();
            }

            }
    }
}
