namespace POOVentas2025
{
    public partial class Form1 : Form
    {
        private Venta _venta;
        public Form1()
        {
            InitializeComponent();
            DgvVenta.AutoGenerateColumns = false;
            gbxTipoVenta.Enabled = false;

            TxtTotal.Text = "0.00";
            TxtTotal.ReadOnly = true;

            DialogResult respuesta =
                MessageBox.Show("Seleccione el tipo de venta:\n" +
                 "Sí = Venta Crédito\n" +
                 "No = Venta Contado",
                "Tipo de Venta", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);


            if (respuesta == DialogResult.Yes)
            {
                RbCrédito.Checked = true;
                RbContado.Checked = false;
                _venta = new VentaCredito();
            }
            else
            {
                RbCrédito.Checked = false;
                RbContado.Checked = true;
                _venta = new VentaContado();
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            DgvVenta.DataSource = null;

            Producto producto = new Producto();
            producto.Cantidad = decimal.Parse(TxtCantidad.Text);
            producto.Descripción = TxtDescripción.Text;
            producto.PrecioUnitario = decimal.Parse(TxtPrecioUnitario.Text);

            _venta.Agregar(producto);

            DgvVenta.DataSource = _venta.Productos;

            _venta.CalculaTotal();
            TxtTotal.Text = _venta.CalculaTotal().ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
