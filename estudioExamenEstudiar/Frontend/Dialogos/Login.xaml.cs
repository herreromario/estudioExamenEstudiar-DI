using estudioExamenEstudiar.Backend.Modelos;
using estudioExamenEstudiar.Backend.Servicios;
using Microsoft.Extensions.Logging;
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
using System.Windows.Shapes;

namespace estudioExamenEstudiar.Frontend.Dialogos
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        private DiinventarioexamenContext _diinventarioexamenContext;
        private UsuarioRepository _usuarioRepository;
        private ILogger<GenericRepository<Usuario>> _logger;
        public Login()
        {
            InitializeComponent();
            // Instanciar el contexto y el repositorio
            _diinventarioexamenContext = new DiinventarioexamenContext();
            _usuarioRepository = new UsuarioRepository(_diinventarioexamenContext, null);
        }

        private async void onBotonLoginPulsado(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(nombreUsuario.Text) && !string.IsNullOrEmpty(claveUsuario.Password))
            {
                // isAutenthicated realiza una funcion que comprueba si existe el usuario y si su contraseña es correcta
                bool isAuthenticated = await _usuarioRepository.LoginAsync(nombreUsuario.Text, claveUsuario.Password);
                if (isAuthenticated)
                {
                    // Como el usuario y la clave son correctos:
                    // Instancia el  nuevo Dialogo, MainWindow
                    MainWindow ventanaPrincipal = new MainWindow();
                    // Enseña el nuevo dialogo
                    ventanaPrincipal.Show();
                    // Cierra el dialogo Login
                    this.Close();
                }
                else // Si algun campo es incorrecto
                {
                    MessageBox.Show("Usuario o clave incorrectos.", "Error de autenticación", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            }
            else // Si no has completado los campos
            {
                MessageBox.Show("Por favor, introduzca usuario y clave.", "Error de autenticación", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
