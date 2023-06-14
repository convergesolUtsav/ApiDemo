using ES.Domain.Entities;
using ES.Domain.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Domain.Context
{
    public class MyDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, int>
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {


        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            int Role_Id = 1;
            int User_Id = 1;

            builder.Entity<ApplicationRole>().HasData(new ApplicationRole() { Id = Role_Id, Name = "Admin", NormalizedName = "Admin" });

            var hasher = new PasswordHasher<ApplicationUser>();

            builder.Entity<ApplicationUser>().HasData(new ApplicationUser()
            {
                Id = User_Id,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "admin@gmail.com",
                NormalizedEmail = "admin@gmail.com",
                PhoneNumber = "0987654321",
                PasswordHash = hasher.HashPassword(null, "Admin@123"),
                SecurityStamp = string.Empty
            });

            builder.Entity<IdentityUserRole<int>>().HasData(new IdentityUserRole<int>()
            {
                UserId = User_Id,
                RoleId = Role_Id
            });
        }
       public DbSet<Exam> Exams { get; set; }
        public DbSet<ExamResults> ExamResults { get; set; }
        public DbSet<QuestionAns> QuestionAns { get; set; }
        public DbSet<Student> Students { get; set; }
    }

}
