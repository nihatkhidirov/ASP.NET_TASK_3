namespace AllUp_Project.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool IsDelete { get; set; }



    }
}
