using Blog.Application.DaoInterfaces;
using Blog.Shared;
using Blog.Shared.Models;
using Blog.Shared.Shared;

namespace Blog.Application.Logic;

public class CommentLogic : ICommentLogic
{
    private readonly IPostDao postDao;
    private readonly ICommentDao commentDao;

    public CommentLogic(IPostDao postDao, ICommentDao commentDao)
    {
        this.postDao = postDao;
        this.commentDao = commentDao;
    }

    public async Task<Comment> CreateAsync(CommentCreationDto dto)
    { 
        Post? post = await postDao.GetByIdAsync(dto.PostId);
        if (post == null)
        {
            throw new Exception($"Post was not found.");
        }
        //
        // User? user = await UserDao.GetByIdAsync(dto.post.authorId);
        // if (post == null)
        // {
        //     throw new Exception($"Current user was not found.");
        // }
        ValidateComment(dto);
        Comment comment = new Comment(new User("trmo","", ""),post,dto.Text);
        Comment created = await commentDao.CreateAsync(comment);
        return created;
    }
    

    public Task<IEnumerable<Comment>> GetAsync(SearchCommentParametersDto searchParameters)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Comment>> GetAllCommentsByPostUrlAsync(string url)
    {
        return await commentDao.GetAllCommentsByPostUrlAsync(url);
    }

    private void ValidateComment(CommentCreationDto dto)
    {
        if (string.IsNullOrEmpty(dto.Text)) throw new Exception("Input cannot be empty.");
    }
}