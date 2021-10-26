namespace auto2
{
    public class Auto:IAuto
    {
        private Radiador radiador;
        private Motor motor;
        private TanqueNafta tanque;

        public Auto()
        {
            this.motor = new Motor(this);
            this.tanque = new TanqueNafta();
            this.radiador = new Radiador(this.motor);
        }
        
        public void Arrancar()
        {
            this.motor.Arrancar();
        }

        public void CargarNafta(int cantidad)
        {
            this.tanque.CargarNafta(cantidad);
        }

        public void avisoExpolsionPiston(double cant)
        {
            this.tanque.consumir(cant);
            System.Console.WriteLine("Me quedan: " + this.tanque.getCantidad() + " litros");
        }

        public void avisoEnfriar()
        {
            this.radiador.avisoEnfriar();
        }
    }
}