using System.Threading;

namespace auto2
{
    public class Motor:IMotor
    {
        private IAuto auto;
        private double temperatura;
        private Piston piston1;
        private Piston piston2;
        private Piston piston3;
        private Piston piston4;
        private Piston piston5;


        public Motor(IAuto delegado)
        {
            this.temperatura = 0;
            this.auto = delegado;
            this.piston1 = new PistonA(this);
            this.piston2 = new PistonA(this);
            this.piston3 = new PistonA(this);
            this.piston4 = new PistonB(this);
            this.piston5 = new PistonB(this);
        }

        public void Arrancar()
        {
            this.piston1.Arrancar();
            this.piston2.Arrancar();
            this.piston3.Arrancar();
            this.piston4.Arrancar();
            this.piston5.Arrancar();
            /* Thread hilo1 = new Thread(this.piston[0].Arrancar);
            Thread hilo2 = new Thread(this.piston[1].Arrancar);
            Thread hilo3 = new Thread(this.piston[2].Arrancar);
            Thread hilo4 = new Thread(this.piston[3].Arrancar);
            Thread hilo5 = new Thread(this.piston[4].Arrancar); */
            /* foreach (var p in this.piston)
            {
                p.Arrancar();
            } */
            /* hilo1.Start();
            hilo2.Start();
            hilo3.Start();
            hilo4.Start();
            hilo5.Start(); */
        }

        public void avisoExpolsionPiston(double cant, double calor)
        {
            this.temperatura += calor;
            System.Console.WriteLine("Temperatura: "+ this.temperatura + "°C");                    
            this.auto.avisoExpolsionPiston(cant);
            if(this.temperatura>=100)
            {
                System.Console.WriteLine("Disminuir Temperatura");
                System.Console.WriteLine("Temperatura antes enfriamiento: "+ this.temperatura);                    
                this.auto.avisoEnfriar();
                System.Console.WriteLine("Temperatura despues enfriamiento: "+ this.temperatura);
            }
        }

        public void Enfriar(double porcentaje)
        {
            this.temperatura *= (1 - porcentaje);
        }
    }
}