
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
    public class MacDonald : FactoryFood
    {
        
        public override Breackfast CreateBoxBreackfast(int choice)
        {

           


            switch (choice)
            {
                case 1:
                    // Coffe cofe = new Coffe();await cofe.OrderMeal();

                    return new Coffe();
                case 2:
                    //Cappuccino cappuccino = new Cappuccino();
                    //await cappuccino.OrderMeal();

                    return new Cappuccino();
                case 3:
                    //Cake cake = new Cake();
                    //return await cake.OrderMeal();
                    return new Cake();
                case 4:
                    //Juice juice = new Juice();
                    //return aw juice.OrderMeal();
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

      

        //public IDinner CreateBoxDinner()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
