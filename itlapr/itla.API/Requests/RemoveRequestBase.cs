namespace itla.API.Requests
{
    public class RemoveRequestBase
    {
        public int? UserDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool Deleted { get; set; }
    }
}
