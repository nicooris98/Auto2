using System.Threading;

namespace auto2
{
    public class PistonB:Piston
    {
        public PistonB(IMotor delegado):base(delegado)
        {
            base.consumo = 0.5;
            base.calor = 0.5;
        }

        public override void Arrancar()
        {
            new Thread(
                () => {
                    for (int i = 0; i < 100; i++)
                    {
                        System.Console.WriteLine("Explosion Piston B");
                        motor.avisoExpolsionPiston(this.consumo, this.calor);
                    }
            }).Start();
        }
    }
}