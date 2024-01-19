using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiudiciaryService.AbstractProduct.AbstractFood
{
    public abstract class Brunch
    {
        public abstract Task<string> OrderMeal();

    }
}
