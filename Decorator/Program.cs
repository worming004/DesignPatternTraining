using System;
using Decorator.DP;
using Decorator.Situation;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            ISheet sheet = new A4Sheet();
            var drunkGuyOrigami = new DrunkGuyOrigami(sheet);
            Console.WriteLine($"height of the sheet : {sheet.Height}");
            Console.WriteLine($"height of the drunk guy origami is divided by 2 because he cannot stand up : {drunkGuyOrigami.Height}");

            ProcessThatGetISheetAsArgument(sheet);
            ProcessThatGetISheetAsArgument(drunkGuyOrigami);

            Console.ReadLine();
        }

        static void ProcessThatGetISheetAsArgument(ISheet sheet)
        {
            // process process process ...
            sheet.RenderAll();
        }
    }
}
