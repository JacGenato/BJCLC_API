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
                new Post {  Title = "New Blog", Content = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Similique unde fugit veniam eius, perspiciatis sunt? Corporis qui ducimus quibusdam, aliquam dolore excepturi quae. Distinctio enim at eligendi perferendis incum quibusdam sed quae"}
            };


            dataContext.AddRange(posts);

            dataContext.SaveChanges();
        }
    }
}
