using Api.Dtos;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public interface IPostRepository
    {
        Task<List<PostDto>> GetAll();
    }

    public class PostRepository : IPostRepository
    {
        private readonly GymmrDbContext context;
        public PostRepository(GymmrDbContext context)
        {
            this.context = context;
        }

        public async Task<List<PostDto>> GetAll()
        {
            return await context.Posts
                .Select(p => new PostDto(p.Id, p.Caption)).ToListAsync();
        }
    }
}