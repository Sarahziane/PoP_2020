using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson5
{
    class Battery
    {
        private int battery_life;
        private string battery_;
        public int Battery_life
        {
            get { return this.battery_life; }
            set {
                if (value < 0)
                { throw new ArgumentOutOfRangeException(); }
                        
              this.battery_life = value; }
        }
        public string Battery_
        {
            get { return this.battery_; }
            set {
                if(value == null)
                { throw new ArgumentNullException(); }
                    this.battery_ = value; }
        }

        public Battery(string battery_, int battery_life)
        {
            this.battery_ = battery_;
            this.battery_life = battery_life;
        }
    }
}
