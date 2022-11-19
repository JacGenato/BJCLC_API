using BJCLC_API.Models;

namespace BJCLC_API.Data
{
    public class DataSeeder
    {
        private readonly DataContext dataContext;

        public DataSeeder(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public void Seed()
        {

            var users = new List<User>
            {
                new User {  Name = "John", Email = "john@gmail.com", MobileNumber = "+18202820232"},
                new User {  Name = "Jac", Email = "Jac@gmail.com", MobileNumber = "+18202820232"},
            };

            dataContext.AddRange(users);

            var posts = new List<Post>
            {
                new Post {  Title = "Tesla Cybertruck-inspired camper trailer for Tesla fans who can’t just wait for the truck!", Content = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Similique unde fugit veniam eius, perspiciatis sunt? Corporis qui ducimus quibusdam, aliquam dolore excepturi quae. Distinctio enim at eligendi perferendis incum quibusdam sed quae", CoverImage="/static/mock-images/covers/cover_1.jpg", CreatedDate=DateTime.Now},
                new Post {  Title = "New Blog2", Content = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Similique unde fugit veniam eius, perspiciatis sunt? Corporis qui ducimus quibusdam, aliquam dolore excepturi quae. Distinctio enim at eligendi perferendis incum quibusdam sed quae", CoverImage="/static/mock-images/covers/cover_2.jpg", CreatedDate=DateTime.Now},
                new Post {  Title = "New Blog3", Content = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Similique unde fugit veniam eius, perspiciatis sunt? Corporis qui ducimus quibusdam, aliquam dolore excepturi quae. Distinctio enim at eligendi perferendis incum quibusdam sed quae", CoverImage="/static/mock-images/covers/cover_3.jpg", CreatedDate=DateTime.Now},
                new Post {  Title = "New Blog4", Content = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Similique unde fugit veniam eius, perspiciatis sunt? Corporis qui ducimus quibusdam, aliquam dolore excepturi quae. Distinctio enim at eligendi perferendis incum quibusdam sed quae", CoverImage="/static/mock-images/covers/cover_4.jpg", CreatedDate=DateTime.Now},
                new Post {  Title = "New Blog", Content = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Similique unde fugit veniam eius, perspiciatis sunt? Corporis qui ducimus quibusdam, aliquam dolore excepturi quae. Distinctio enim at eligendi perferendis incum quibusdam sed quae", CoverImage="/static/mock-images/covers/cover_1.jpg", CreatedDate=DateTime.Now},
                new Post {  Title = "New Blog2", Content = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Similique unde fugit veniam eius, perspiciatis sunt? Corporis qui ducimus quibusdam, aliquam dolore excepturi quae. Distinctio enim at eligendi perferendis incum quibusdam sed quae", CoverImage="/static/mock-images/covers/cover_2.jpg", CreatedDate=DateTime.Now},
                new Post {  Title = "New Blog3", Content = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Similique unde fugit veniam eius, perspiciatis sunt? Corporis qui ducimus quibusdam, aliquam dolore excepturi quae. Distinctio enim at eligendi perferendis incum quibusdam sed quae", CoverImage="/static/mock-images/covers/cover_3.jpg", CreatedDate=DateTime.Now},
                new Post {  Title = "New Blog4", Content = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Similique unde fugit veniam eius, perspiciatis sunt? Corporis qui ducimus quibusdam, aliquam dolore excepturi quae. Distinctio enim at eligendi perferendis incum quibusdam sed quae", CoverImage="/static/mock-images/covers/cover_4.jpg", CreatedDate=DateTime.Now}

            };


            dataContext.AddRange(posts);

            dataContext.SaveChanges();
        }
    }
}
