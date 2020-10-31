using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson5
{
    public  class Laptop
    {
        private string model;
        private string manufacturer;

        public string Model
        {
            get { return this.model; }
            set {
                if (value == null)
                { throw new ArgumentNullException(); }
                this.model = value; }
        }
        public string Manufacturer
        {
            get { return this.manufacturer; }
            set {
                if (value == null)
                { throw new ArgumentNullException(); }
                this.manufacturer = value; }
        }
        private int ram;
        private string processor;
        public int Ram
        {
            get { return this.ram; }
            set { this.ram = value; }
        }
        public string Processor
        {
            get { return this.processor; }
            set {
                if (value == null)
                { throw new ArgumentNullException(); }
                this.processor = value; }
        }
        private int hdd;
        private string graphics_card;
        public int Hdd
        {
            get { return this.hdd; }
            set
            {
                if (value < 0)
                { throw new ArgumentOutOfRangeException(); }
                this.hdd = value; }
        }
        public string Graphics_card
        {
            get { return this.graphics_card; }
            set {
                if (value == null)
                { throw new ArgumentNullException(); }
                this.graphics_card = value; }
        }
       
        private int price;
        private string screen;
        public int Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                { throw new ArgumentOutOfRangeException(); }
                this.price = value; }
        }
        public string Screen
        {
            get { return this.screen; }
            set {
                if (value == null)
                { throw new ArgumentNullException(); }
                this.screen = value; }
        }

        Battery battery_info = new Battery("type of battery", 50);


        public Laptop ()
        {
            this.price = price;
            this.model = model;
            //.............etc
        }

        public override string ToString()
        {
            return
                                 "\nBattery : \n\n"
                                 +  battery_info

                                 + "\n Screen"
                                 + Screen
                                  +"\n Model"
                                  +Model
                                  +"\n Graphic card"
                                  +Graphics_card
                                  +"\n Price"
                                  +Price
                                 
                                 
                                 //+............etc
                                 
                                 
                                 
                                 
                                 
                                 ;
        }


    }
}
