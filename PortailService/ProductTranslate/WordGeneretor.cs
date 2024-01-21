using PortailService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortailService.AbstractTranslate
{
    public class WordGeneretor : TranslateDoc
    {
        public override async Task<string> GenerateTranslate(string lang)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"The WORD document waiting for translation into {lang}");
            Console.ResetColor();
            Console.WriteLine($"-------------------------------");
            await Task.Delay(10000);

            return "WORD";
        }
    }
}
