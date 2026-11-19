namespace Examen_Cafeteria_Albert
{
    public partial class frmPedidos : Form
    {
        private decimal subtotal;

        public frmPedidos()
        {
            InitializeComponent();
            btnAgregar.Click += btnAgregar_Click;
            btnCalcular.Click += btnCalcular_Click;
            btnLimpiar.Click += btnLimpiar_Click;
            btnSalir.Click += btnSalir_Click;
        }

        private void frmPedidos_Load(object sender, EventArgs e)
        {
            nudCantidad.Minimum = 1;
            nudCantidad.Maximum = 20;
            lblEncabezado.Text = "PEDIDO DE CAFETERÍA";
            ConfigurarPedidoNuevo();
        }

        private void ConfigurarPedidoNuevo()
        {
            subtotal = 0m;
            lstPedido.Items.Clear();
            lstPedido.Items.Add(FormatearEncabezado());

            TxtCliente.Clear();
            dtpFecha.Value = DateTime.Today;
            ChkFrecuente.Checked = false;
            rbtNormal.Checked = true;
            rbtLocal.Checked = true;
            LimpiarProducto();
            lblSubtotal.Text = FormatearImporte(0m);
            lblDescuento.Text = FormatearImporte(0m);
            lblEmpaque.Text = FormatearImporte(0m);
            lblItbis.Text = FormatearImporte(0m);
            lblTotal.Text = FormatearImporte(0m);
            TxtCliente.Focus();
        }

        private void LimpiarProducto()
        {
            txtProducto.Clear();
            txtPrecio.Clear();
            nudCantidad.Value = 1;
            rbtNormal.Checked = true;
            checkBox1.Checked = false;
        }

        private string FormatearEncabezado()
        {
            return "Cant".PadRight(6) + "Producto".PadRight(24) +
                   "Precio".PadLeft(10) + "Total".PadLeft(12);
        }

        private static string FormatearImporte(decimal importe)
        {
            return $"RD$ {importe:N2}";
        }

        private void btnAgregar_Click(object? sender, EventArgs e)
        {
            string producto = txtProducto.Text.Trim();
            if (string.IsNullOrWhiteSpace(producto))
            {
                MessageBox.Show("Digite el nombre del producto.", "Datos incompletos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProducto.Focus();
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text.Trim(), out decimal precio) || precio < 0)
            {
                MessageBox.Show("Digite un precio válido mayor o igual que cero.", "Datos inválidos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
                return;
            }

            int cantidad = (int)nudCantidad.Value;
            decimal precioUnitario = precio;
            string tamano = "normal";

            if (rbtGrande.Checked)
            {
                precioUnitario += 25m;
                tamano = "grande";
            }

            if (checkBox1.Checked)
            {
                precioUnitario += 30m;
            }

            decimal totalLinea = precioUnitario * cantidad;
            subtotal += totalLinea;

            string descripcion = $"{producto} ({tamano})";
            string linea = cantidad.ToString().PadRight(6) +
                           descripcion.PadRight(24) +
                           //Agregando los margenes
                           precioUnitario.ToString("N2").PadLeft(10) +
                           totalLinea.ToString("N2").PadLeft(12);
            lstPedido.Items.Add(linea);
            lblSubtotal.Text = FormatearImporte(subtotal);
            LimpiarProducto();
            txtProducto.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        /// aqui en el metodo del botonCalula con la funcion de CLic se dan las funcioes

        private void btnCalcular_Click(object? sender, EventArgs e)
        {
            if (subtotal <= 0m)
            {
                //Aqui si no se agrega el pedido osea un producto pues no se puede dejar nada vacio
                MessageBox.Show("Agregue al menos un producto antes de calcular.", "Pedido vacío",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal descuento = ChkFrecuente.Checked ? subtotal * 0.10m : 0m;
            decimal empaque = rbtLlevar.Checked ? 20m : 0m;
            decimal baseSimple = subtotal - descuento + empaque;
            decimal itbis = baseSimple * 0.18m;
            decimal total = baseSimple + itbis;

            lblSubtotal.Text = FormatearImporte(subtotal);
            lblDescuento.Text = FormatearImporte(descuento);
            lblEmpaque.Text = FormatearImporte(empaque);
            lblItbis.Text = FormatearImporte(itbis);
            lblTotal.Text = FormatearImporte(total);
        }

        private void btnLimpiar_Click(object? sender, EventArgs e)
        {
            ConfigurarPedidoNuevo();
        }

        private void btnSalir_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lstPedido_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}

 