using Core.Common;

namespace Core.Enumerations
{
    public class Foot : Enumeration
    {
        public static Foot Right = new Foot(1, nameof(Right));
        public static Foot Left = new Foot(2, nameof(Left));

        private Foot(int id, string name) : base(id, name)
        {
        }
    }
}
