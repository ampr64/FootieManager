using System;

namespace ApplicationCore.Common
{
    public abstract class Entity
    {
        public int Id { get; set; }

        public DateTime CreatedOn { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? LastModifiedOn { get; set; }

        public string LastModifiedBy { get; set; }
    }
}
