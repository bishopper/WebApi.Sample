namespace WebApi.Sample.Models.Entities
{
    public class ToDo
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime InsertTime { get; set; }
        public bool IsRemoved { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}
