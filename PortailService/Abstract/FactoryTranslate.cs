using PortailService.AbstractTranslate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortailService.Abstract
{
    public abstract class FactoryTranslate
    {
      public abstract TranslateDoc CreateGenerator(string type);


    }
}
