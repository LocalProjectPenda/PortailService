
using GiudiciaryService.AbstractProduct.AbstractFood;
using PortailService.Abstract;
using PortailService.AbstractFood;
using PortailService.Product.ProductBreackfast;
using PortailService.ProductBreackfast;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortailService.Concrete
{
    public class Starbucks : FactoryFood
    {
        public override Breackfast CreateBoxBreackfast(int choice)
        {
            switch (choice)
            {
                case 1:
                    return new Coffe();
                case 2:
                    return new Cappuccino();
                case 3:
                    return new Cake();
                case 4:
                    return new Juice();

            }
            return null;
        }

        public override Brunch CreateBoxLunch(int choice)
        {
            switch (choice)
            {
                case 1:
                    return new Burger();
                case 2:
                    return new Nuggets();
                case 3:
                    return new Chips();
                case 4:
                    return new Beverage();

            }

            return null;
        }
    }
}
