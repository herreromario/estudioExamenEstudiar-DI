using estudioExamenEstudiar.Frontend.Dialogos;
using MaterialDesignColors;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace estudioExamenEstudiar.Frontend.UserControls
{
    /// <summary>
    /// Lógica de interacción para NuevoArticuloUserControl.xaml
    /// </summary>
    public partial class NuevoArticuloUserControl : UserControl
    {
        public NuevoArticuloUserControl()
        {
            InitializeComponent();
        }

        private void onNuevoArticuloPulsado(object sender, RoutedEventArgs e)
        {
            var ventana = new GestionModeloArticulo();
            ventana.ShowDialog(); // ShowDialog() si quieres que bloquee la ventana principal
        }

    }
}
