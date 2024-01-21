using PortailService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortailService.AbstractTranslate
{
    public class PdfGeneretor : TranslateDoc
    {
       

 public override async Task<string> GenerateTranslate(string lang)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"The PDF document waiting for translation into {lang}");
            Console.ResetColor();
            Console.WriteLine($"-------------------------------");
            await Task.Delay(10000);

            return "PDF";
        }
    
    }
}
