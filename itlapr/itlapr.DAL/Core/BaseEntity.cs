namespace itlapr.DAL.Core
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            this.CreationDate = DateTime.Now;
            this.Deleted = false;
        }

        public DateTime CreationDate { get; set; }
        public DateTime ModifyDate { get; set; }
        public DateTime DeleteDate { get; set; }
        public int? UserMod { get; set; }
        public int CreationUser { get; set; }
        public int? UserDeleted { get; set; }
        public bool Deleted { get; set; }

    }
}
