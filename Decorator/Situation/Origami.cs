using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Situation
{
    public abstract class Origami
    {
        public abstract bool? CanStandUp { get; }
        private ISheet madeFromSheet;
    }

    public class MonkeyOrigami : Origami
    {
        public override bool? CanStandUp => true;
    }

    public class DrunkGuyOrigami : Origami
    {
        public override bool? CanStandUp => false;
    }

    public class PisaTowerOrigami : Origami
    {
        public override bool? CanStandUp => null;
    }
}
