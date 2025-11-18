using estudioExamenEstudiar.Frontend.Dialogos;
using System;
using System.Collections.Generic;
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
    /// Lógica de interacción para NuevoModeloArticuloUserControl.xaml
    /// </summary>
    public partial class NuevoModeloArticuloUserControl : UserControl
    {
        public NuevoModeloArticuloUserControl()
        {
            InitializeComponent();
        }

        private void onNuevoModeloArticuloPulsado(object sender, RoutedEventArgs e)
        {
            var ventana = new GestionModeloArticulo();
            ventana.ShowDialog(); // ShowDialog() si quieres que bloquee la ventana principal
        }
    }
}
