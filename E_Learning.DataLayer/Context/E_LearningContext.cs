using E_Learning.DataLayer.Entities.User;
using Microsoft.EntityFrameworkCore;

namespace E_Learning.DataLayer.Context
{
    public class E_LearningContext : DbContext
    {
        public E_LearningContext(DbContextOptions<E_LearningContext> options) : base(options)
        {

        }


        #region User

        public DbSet<Role> Roles { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<UserRole> UserRoles { get; set; }

        #endregion



    }
}
