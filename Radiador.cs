namespace auto2
{
    public class Radiador
    {
        private double cantEnfriar;
        private IMotor motor;

        public Radiador(IMotor delegado)
        {
            this.cantEnfriar = 0.6;
            this.motor = delegado;
        }

        public void avisoEnfriar()
        {
            this.motor.Enfriar(this.cantEnfriar);
        }
        
    }
}