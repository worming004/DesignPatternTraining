using System;
using System.Collections.Generic;
using System.Text;
using Decorator.Situation;

namespace Decorator.DP
{
    public abstract class OrigamiSheetDecorator : ISheet
    {
        private ISheet _sheet;
        
        OrigamiSheetDecorator(ISheet sheet)
        {
            this._sheet = sheet;
        }

        public Render()
        {
            return this._sheet.Render();
        }

        public abstract Origami MakeOrigami();
    }

    public 
}
