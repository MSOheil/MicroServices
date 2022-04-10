namespace CommandService.Models.Common
{
    public interface IBaseModel
    {
        public int Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
