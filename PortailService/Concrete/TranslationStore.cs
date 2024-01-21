using PortailService.Abstract;
using PortailService.AbstractTranslate;
using PortailService.ProductTranslate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortailService.Concrete
{
    public class TranslationStore : FactoryTranslate
    {
        public override TranslateDoc CreateGenerator(string type)
        {
            return type switch
            {
                "html" => new HtmlGeneretor(),
                "pdf" => new PdfGeneretor(),
                "word" => new WordGeneretor(),
                   _ => throw new ArgumentException("Invalid report type"),

            } ; 
        }
    }
}
