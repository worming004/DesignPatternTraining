using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Situation
{
    public interface ISheet
    {
        int Width { get; }
        int Height { get; }
    }


    public class A4Sheet : ISheet
    {
        public int Width { get => 16; }
        public int Height { get => 30; }


        private List<ISign<Object>> _content = new List<ISign<Object>>();


        public void AddSign(ISign<Object> sign)
        {
            this._content.Add(sign);
        }

        public IEnumerable<Object> RenderAll()
        {
            var result = new List<Object>();
            foreach (var c in _content)
            {
                result.Add(c.Render());
            }
            return result;
        }
    }
}
