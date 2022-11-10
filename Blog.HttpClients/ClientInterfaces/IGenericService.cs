namespace Blog.BlazorWASM;

public interface IGenericService<T,U>
{
    public Task<ICollection<T>> GetListAsync();
    public Task<T> GetElementAsync(U id);
    public Task<T> AddElementAsync(T element);
    public Task DeleteElementAsync(U id);
    public Task UpdateElementAsync(T element);
}