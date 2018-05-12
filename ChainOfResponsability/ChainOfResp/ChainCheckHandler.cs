using ChainOfResponsibility.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.ChainOfResp
{
    public abstract class ChainCheckHandler
    {
        private ChainCheckHandler nextChecker;

        public void AddHandler(ChainCheckHandler handl)
        {
            if (nextChecker == null)
                nextChecker = handl;
            else
                nextChecker.AddHandler(handl);
        }
        public abstract void HandleRequest(Car car);
        public void Next(Car car)
        {
            this.HandleRequest(car);
            if (nextChecker != null)
            {
                nextChecker.Next(car);
            }
        }
    }
}
