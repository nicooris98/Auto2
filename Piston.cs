namespace auto2
{
    public abstract class Piston
    {
        protected IMotor motor;
        protected double consumo;
        protected double calor;

        public Piston(IMotor delegado)
        {
            this.motor = delegado;
            this.consumo = 1;
            this.calor = 1;
        }

        public virtual void Arrancar(){
            /* for (int i = 0; i < 100; i++)
            {
                System.Console.WriteLine("Explosion Piston");
                motor.avisoExpolsionPiston(this.consumo, this.calor);
            } */
        }
    }
}