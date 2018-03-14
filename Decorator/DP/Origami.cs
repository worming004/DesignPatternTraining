using Decorator.Situation;
using System.Collections.Generic;
using System.Linq;

namespace Decorator.DP
{
    public abstract class Origami : ISheet
    {
        public abstract bool? CanStandUp { get; }

        public virtual int Width => madeFromSheet.Width;

        public virtual int Height => madeFromSheet.Height;

        public int SignCount => madeFromSheet.SignCount;

        protected ISheet madeFromSheet;

        public void AddSign(ISign<object> sign)
        {
            madeFromSheet.AddSign(sign);
        }

        public IEnumerable<object> RenderAll()
        {
            // render only half of them because of half are hidden
            return madeFromSheet.RenderAll().Take(SignCount/2);
        }
    }

    public class MonkeyOrigami : Origami
    {
        public MonkeyOrigami(ISheet sheet)
        {
            this.madeFromSheet = sheet;
        }
        public override bool? CanStandUp => true;
    }

    public class DrunkGuyOrigami : Origami
    {
        public DrunkGuyOrigami(ISheet sheet)
        {
            this.madeFromSheet = sheet;
        }
        public override int Height => this.madeFromSheet.Height / 2;
        public override bool? CanStandUp => false;
    }

    public class PisaTowerOrigami : Origami
    {
        public PisaTowerOrigami(ISheet sheet)
        {
            this.madeFromSheet = sheet;
        }
        public override bool? CanStandUp => null;
    }
}
