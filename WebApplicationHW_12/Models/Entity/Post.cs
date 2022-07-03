using WebApplicationHW_12.Models.Entity;

namespace WebApplicationHW_12.Infrastructure.DataBase
{
    public class Post
    {
        public int ID { get; set; }
        public string PostTitle { get; set; }
        public int BlogID { get; set; }
        public Blog Blog { get; set; }
        public ICollection<PostTag> PostTags { get; set; }
    }
}
