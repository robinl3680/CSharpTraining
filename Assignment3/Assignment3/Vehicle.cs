using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Vehicle
    {
        private int speed;
        public Vehicle(int speed)
        {
            this.speed = speed;
        }

        public int Speed { get => speed; set => speed = value; }

        public void IncrementSpeed(int speed)
        {
            this.speed = speed + this.speed;
            if (this.speed > 100)
                throw new OverSpeedException("Exception : Over speeding vehicle");
        }
        
    }
}
