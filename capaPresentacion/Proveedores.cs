using System;
using System.Linq;
using System.Windows.Forms;
using POLIRUBRO.capaNegocio;

namespace POLIRUBRO.capaPresentacion
{
    public partial class Proveedores : Form
    {
        private CargarProveedor negocioProveedores = new CargarProveedor();
        private CargarProveedor.Proveedor proveedorSeleccionado;

        public Proveedores()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            CargarProveedores();

            // Asignar eventos
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            dgvProveedores.CellDoubleClick += dgvProveedores_CellDoubleClick;
        }

        private void ConfigurarDataGridView()
        {
            dgvProveedores.AutoGenerateColumns = false;

            dgvProveedores.Columns.Clear();
            dgvProveedores.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Id",
                HeaderText = "Id",
                DataPropertyName = "Id",
                Visible = false
            });
            dgvProveedores.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Nombre",
                HeaderText = "Nombre",
                DataPropertyName = "Nombre"
            });
            dgvProveedores.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "CUIT",
                HeaderText = "CUIT",
                DataPropertyName = "CUIT"
            });
            dgvProveedores.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Domicilio",
                HeaderText = "Domicilio",
                DataPropertyName = "Domicilio"
            });
            dgvProveedores.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Telefono",
                HeaderText = "Teléfono",
                DataPropertyName = "Telefono"
            });
        }

        private void CargarProveedores()
        {
            var proveedores = negocioProveedores.ObtenerProveedores();
            dgvProveedores.DataSource = null;
            dgvProveedores.DataSource = proveedores;
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                var nuevoProveedor = new CargarProveedor.Proveedor
                {
                    Nombre = txtNombre_proveedor.Text,
                    CUIT = txtCUIT.Text,
                    Domicilio = txtDomicilio.Text,
                    Telefono = txtTelefono.Text
                };

                negocioProveedores.InsertarProveedor(nuevoProveedor);
                MessageBox.Show("Proveedor agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                CargarProveedores();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarProveedor_Click(object sender, EventArgs e)
        {
            if (proveedorSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un proveedor de la lista para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                proveedorSeleccionado.Nombre = txtNombre_proveedor.Text;
                proveedorSeleccionado.CUIT = txtCUIT.Text;
                proveedorSeleccionado.Domicilio = txtDomicilio.Text;
                proveedorSeleccionado.Telefono = txtTelefono.Text;

                negocioProveedores.ModificarProveedor(proveedorSeleccionado);
                MessageBox.Show("Proveedor modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                CargarProveedores();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var confirmacion = MessageBox.Show("¿Seguro que desea cancelar los cambios?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion == DialogResult.Yes)
            {
                LimpiarFormulario();
                proveedorSeleccionado = null;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.ToLower();
            btnRefrescar.Enabled = !string.IsNullOrWhiteSpace(txtBuscar.Text);
            var proveedores = negocioProveedores.ObtenerProveedores();

            var filtrados = proveedores.Where(p =>
                p.Nombre.ToLower().Contains(filtro) ||
                p.CUIT.ToLower().Contains(filtro) ||
                p.Domicilio.ToLower().Contains(filtro) ||
                p.Telefono.ToLower().Contains(filtro)).ToList();

            dgvProveedores.DataSource = null;
            dgvProveedores.DataSource = filtrados;
        }

        private void dgvProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            proveedorSeleccionado = dgvProveedores.Rows[e.RowIndex].DataBoundItem as CargarProveedor.Proveedor;

            if (proveedorSeleccionado != null)
            {
                txtNombre_proveedor.Text = proveedorSeleccionado.Nombre;
                txtCUIT.Text = proveedorSeleccionado.CUIT;
                txtDomicilio.Text = proveedorSeleccionado.Domicilio;
                txtTelefono.Text = proveedorSeleccionado.Telefono;
            }
        }
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            CargarProveedores();
            MessageBox.Show("Lista de proveedores actualizada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LimpiarFormulario()
        {
            txtNombre_proveedor.Clear();
            txtCUIT.Clear();
            txtDomicilio.Clear();
            txtTelefono.Clear();
            proveedorSeleccionado = null;
        }

        private void txtCUIT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '(' && e.KeyChar != ')' && e.KeyChar != '-' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            if (proveedorSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un proveedor de la lista para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmacion = MessageBox.Show($"¿Está seguro que desea eliminar el proveedor {proveedorSeleccionado.Nombre}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    negocioProveedores.EliminarProveedor(proveedorSeleccionado.Id);
                    MessageBox.Show("Proveedor eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                    CargarProveedores();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el proveedor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}