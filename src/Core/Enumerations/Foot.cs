using Core.Common;

namespace Core.Enumerations
{
    public class Foot : Enumeration
    {
        public static Enumeration Right = new Foot(1, nameof(Right));
        public static Enumeration Left = new Foot(2, nameof(Left));

        private Foot(int value, string name) : base(value, name)
        {
        }
    }
}
