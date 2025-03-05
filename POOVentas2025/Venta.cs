namespace POOVentas2025
{

    public abstract class Venta
    {
        private int _tope;
        private Producto[] _productos;

        protected Venta()
        {
            _tope = 0;
            _productos = new Producto[5];
        }

        public Producto[] Productos 
        { 
            get 
            { 
                return _productos; 
            } 
        }

        public abstract decimal CalculaTotal();

        public void Agregar(Producto producto) 
        {
            _productos[_tope] = producto;
            _tope++;
        }
    }
}
