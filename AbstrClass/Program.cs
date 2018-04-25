using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrClass
{
    abstract class Car
    {
        string mark;
        string mode;
        public Car(string Mark, string Mode)
        {
            mark = Mark;
            mode = Mode;
        }
        private string Move()
        {
            string movestatus = "i'm moving";
            Console.WriteLine(movestatus);
            return movestatus;
            
        }
        private void Stop()
        {
            string stopstatus = "i'm don't move now";
            Console.WriteLine(stopstatus);
        }
        public void move()
        {
            Console.WriteLine(mark + " " + mode);
             Move();
        }
        public void stop()
        {
            Console.WriteLine(mark + " " + mode);
             Stop();
        }
        public abstract void ChangeGear();

    }
    class AutoCar : Car
    {
        string gearType = "Auto geare";
        public AutoCar(string GearType, string Mark, string Mode) : base ( Mark, Mode)
        {
            GearType = gearType; 
        }
        public override void ChangeGear()
        {
            Console.WriteLine($"gear is: {0} {mark}", gearType); ;
        }
    }
    class ManualCar : Car
    {
        string gearType = "Manual Gear";
        public ManualCar(string GeareType, string Mark, string Mode): base(Mark, Mode)
        {
            GeareType = gearType;
        }
        public override void ChangeGear()
        {
            Console.WriteLine("gear is: {0} without mistakes",gearType);
            
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello\n");
            AutoCar autoCar = new AutoCar("", "Dewwo", "Lanos");
            autoCar.move();
            autoCar.ChangeGear();
            Console.WriteLine();
            ManualCar manualCar = new ManualCar("","Audi","A6");
            manualCar.stop();
            manualCar.ChangeGear();


            Console.ReadLine();
        }
    }

}
