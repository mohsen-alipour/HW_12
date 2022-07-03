using WebApplicationHW_12.Models.Entity;

namespace WebApplicationHW_12.Infrastructure.DataBase
{
    public class Tag
    {
        public int ID { get; set; }
        public string TagName { get; set; }
        public ICollection<PostTag> PostTags { get; set; }
    }
}
