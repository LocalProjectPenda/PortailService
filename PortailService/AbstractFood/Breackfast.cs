
using PortailService.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortailService.AbstractFood
{
    public  abstract class Breackfast
    {
        public abstract Task<string> OrderMeal();

    }
}
