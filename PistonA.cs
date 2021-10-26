using System.Threading;

namespace auto2
{
    public class PistonA:Piston
    {
        public PistonA(IMotor delegado):base(delegado)
	    {
		    base.consumo = 1;
		    base.calor = 1;
	    }

        public override void Arrancar()
        {
            new Thread(
                () => {
                    for (int i = 0; i < 100; i++)
                    {
                        System.Console.WriteLine("Explosion Piston A");
                        motor.avisoExpolsionPiston(this.consumo, this.calor);
                    }
            }).Start();
        }
    }
}
