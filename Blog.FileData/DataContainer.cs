using Blog.Shared;

namespace Blog.FileData;

public class DataContainer
{
    public ICollection<Post> Posts { get; set; }
}