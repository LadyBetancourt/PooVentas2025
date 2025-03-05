namespace POOVentas2025
{
    public class Producto
    {
        public decimal Cantidad { get; set; } = 0.00m;
        public string Descripción { get; set; } = string.Empty;
        public decimal PrecioUnitario { get; set; } = 0.00m;
        public decimal Importe
        {
            get
            {
                return CalcularImporte();
            }
        }

        public decimal CalcularImporte()
        {
            return Cantidad * PrecioUnitario;
        }
    }
}
