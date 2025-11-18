using estudioExamenEstudiar.Backend.Modelos;
using estudioExamenEstudiar.Backend.Servicios;
using MahApps.Metro.Controls;
using Microsoft.Extensions.Logging;
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

namespace estudioExamenEstudiar.Frontend.Dialogos
{
    public partial class GestionModeloArticulo : MetroWindow
    {
        public GestionModeloArticulo()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private async void BtnGuardar_Click(Object sender, RoutedEventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string marca = txtMarca.Text.Trim();
            string modelo = txtModelo.Text.Trim();
            string tipoTexto = txtTipo.Text.Trim();
            string descripcion = txtDescripcion.Text.Trim();

            // Validaciones
            if (string.IsNullOrEmpty(nombre) ||
                string.IsNullOrEmpty(marca) ||
                string.IsNullOrEmpty(modelo) ||
                string.IsNullOrEmpty(tipoTexto))
            {
                MessageBox.Show("Los campos Nombre, Marca y Tipo son obligatorios.",
                                "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;

            }

            if (!int.TryParse(tipoTexto, out int tipoId))
            {
                MessageBox.Show("El campo Tipo debe ser un número válido.",
                                "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;

            }

            try
            {
                using var context = new DiinventarioexamenContext();

                var repo = new ModeloArticuloRepository(
                    context,
                    new LoggerFactory().CreateLogger<GenericRepository<Modeloarticulo>>());

                // ¿Existe ya un modelo con ese nombre?

                if (await repo.ExistsByNameAsync(nombre))
                {
                    MessageBox.Show("Ya existe un modelo con ese nombre.",
                                    "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                // Crear el modelo
                var nuevoModelo = new Modeloarticulo
                {
                    Nombre = nombre,
                    Marca = marca,
                    Modelo = modelo,
                    Tipo = tipoId,
                    Descripcion = descripcion
                };

                // Guardar en la BD
                await repo.AddAsync(nuevoModelo);

                MessageBox.Show("Modelo guardado correctamente.",
                                "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);

                this.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el modelo: {ex.Message}",
                                "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
