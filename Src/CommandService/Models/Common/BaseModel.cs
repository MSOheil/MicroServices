namespace CommandService.Models.Common
{
    public class BaseModel : IBaseModel
    {
        public int Id { get; set; }
        public DateTime? CreateDate { get; set; } = DateTime.UtcNow;
        public DateTime? ModifiedDate { get; set; }

      
    }
}
