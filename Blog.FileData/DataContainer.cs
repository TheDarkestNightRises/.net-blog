using Blog.Shared;
using Blog.Shared.Models;

namespace Blog.FileData;

public class DataContainer
{
    public ICollection<Post> Posts { get; set; }
    public ICollection<Comment> Comments { get; set; }
}