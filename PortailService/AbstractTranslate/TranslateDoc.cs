using PortailService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortailService.AbstractTranslate
{
    public abstract class TranslateDoc
    {
        public abstract Task<string> GenerateTranslate(string lang);
    }
}
