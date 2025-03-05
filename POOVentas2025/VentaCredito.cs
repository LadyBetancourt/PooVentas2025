namespace POOVentas2025
{
    internal class VentaCredito : Venta
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

            return total * 1.05m;
        }
    }
}
