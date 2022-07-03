namespace WebApplicationHW_12.Infrastructure.DataBase
{
    public class Blog
    {
        public int ID { get; set; }
        public string BlogTitle { get; set; }
        public string BlogAddress { get; set; }
        public ICollection<Post> Posts { get; set; }
        public Blogimag blogimage { get; set; }

    }

}
