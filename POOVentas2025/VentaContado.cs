namespace POOVentas2025
{
    internal class VentaContado : Venta
    {
        public override decimal CalculaTotal()
        {
            decimal total = 0.00m;

            foreach (Producto producto in Productos)
            {
                if (producto != null)
                {
                    total += producto.Importe;
                }
            }

            return total;
        }
    }
}
