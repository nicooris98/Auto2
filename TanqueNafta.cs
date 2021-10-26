namespace auto2
{
    public class TanqueNafta
    {
        private double cantidad;

        public TanqueNafta()
        {
            this.cantidad = 0;
        }

        public void consumir()
        {
            this.cantidad--;
        }

        public void consumir(double cant)
        {
            this.cantidad -= cant;
        }

        public void CargarNafta(int cantidad)
        {
            this.cantidad = cantidad;
        }

        public double getCantidad()
        {
            return this.cantidad;
        }
    }
}