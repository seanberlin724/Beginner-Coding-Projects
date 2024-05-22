using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetCalculator
{
    class Carpet
    {
        private double pricePerSqYard;
        private double noOfSquareYards;
        private double length;
        private double width;
        private double price;
        public Carpet()
        {
            pricePerSqYard = 4;
            noOfSquareYards = 10;
            length = 5;
            width = 6;
            price = pricePerSqYard * noOfSquareYards;
        }
        public Carpet(double PricePerSqYard, double Length, double Width)
        {
            pricePerSqYard = PricePerSqYard;
            length = Length;
            width = Width;
            noOfSquareYards = totalNoOfSquareYardsGetterSetter;
            price = Price;
        }
        public double Price //*
        {
            get { return pricePerSqYard * noOfSquareYards; }
            set { Price = value; }
        }
        public double totalNoOfSquareYardsGetterSetter
        {
            get { return length * width / 9; }
            set { noOfSquareYards = value; }
        }
        public override string ToString()

        {
            return "Price Per Square Yard: " + pricePerSqYard.ToString("C") +

             "\nTotal Square Yards: " + noOfSquareYards.ToString("F1") +

                "\nTotal Price: " + Price.ToString("C");
        }
    }
}
