using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Situation
{
    //public interface ISign { }
    public interface ISign<T> {
        T Render();
    }
    class Text : ISign<string>
    {
        private string _text;
        Text(string text)
        {
            this._text = text;
        }
        public string Render()
        {
            return this._text;
        }
    }
    class Draw: ISign<Object>
    {
        private Object _draw;
        Draw(Object drawn)
        {
            this._draw = drawn;
        }
        public Object Render()
        {
            return this._draw;
        }
    }

}
