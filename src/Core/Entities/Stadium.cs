using Core.Common;

namespace Core.Entities
{
    public class Stadium : Entity<int>
    {
        public string Name { get; set; }

        public int ClubId { get; set; }

        public Club Club { get; set; }

        public int Capacity { get; set; }

        public int BuiltIn { get; set; }
    }
}
