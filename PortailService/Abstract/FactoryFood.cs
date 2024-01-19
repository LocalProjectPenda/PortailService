
using GiudiciaryService.AbstractProduct.AbstractFood;
using PortailService.AbstractFood;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortailService.Abstract
{
    public  abstract class FactoryFood
    {
        
        public abstract Breackfast CreateBoxBreackfast(int choice);
        public abstract Brunch CreateBoxLunch(int choice);
        
    }
}
