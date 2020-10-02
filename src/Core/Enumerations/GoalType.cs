using Core.Common;

namespace Core.Enumerations
{
    public class GoalType : Enumeration
    {
        public static GoalType OpenPlay = new GoalType(1, "Open play");
        public static GoalType Header = new GoalType(2, nameof(Header));
        public static GoalType Penalty = new GoalType(3, nameof(Penalty));
        public static GoalType FreeKick = new GoalType(4, "Free kick");
        public static GoalType Corner = new GoalType(5, nameof(Corner));

        private GoalType(int value, string name) : base(value, name)
        {
        }
    }
}
