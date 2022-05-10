using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class SeedData
    {
        public static void Seed(ModelBuilder builder)
    {
         builder.Entity<PostEntity>().HasData(new List<PostEntity> {
            new PostEntity {
                Id = 1,
                Caption = "First post"
            },
            new PostEntity {
                Id = 2,
                Caption = "Second post"
            },
            new PostEntity {
                Id = 3,
                Caption = "Third post"
            },
        });
    }
    }
}