using WebApplicationHW_12.Infrastructure.DataBase;

namespace WebApplicationHW_12.Models.Entity
{
    public class PostTag
    {
        public int? ID { get; set; }
        public string? name { get; set; }
        public int? PostID { get; set; }
        public post? Post { get; set; }
        public int? TagID { get; set; }
        public Tag? Tag { get; set; }
      
    }
}
