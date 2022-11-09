using Microsoft.EntityFrameworkCore;
using proUserInfoManagement.Api.Entities;
using System.Xml.Serialization;

namespace proUserInfoManagement.Api.Data
{
    public class UserInfoManagementDbContext:DbContext
    {

        public UserInfoManagementDbContext(DbContextOptions<UserInfoManagementDbContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                FName = "Vahid",
                LName = "Vosoughi",
                UserName = "vahid",
                PassWord = "123",
                NationalCode = "123456789",
                CreateDateTime = DateTime.Now,
                ExpireDateTime = Convert.ToDateTime("2025/05/05"),

            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 2,
                FName = "Ayoob",
                LName = "Khani",
                UserName = "Ayoob",
                PassWord = "123",
                NationalCode = "123456789",
                CreateDateTime = DateTime.Now,
                ExpireDateTime = Convert.ToDateTime("2025/05/05"),
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 3,
                FName = "Mehdi",
                LName = "Hassani",
                UserName = "Mehdi",
                PassWord = "123",
                NationalCode = "123456789",
                CreateDateTime = DateTime.Now,
                ExpireDateTime = Convert.ToDateTime("2025/05/05"),
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 4,
                FName = "Vahid",
                LName = "Fazeli",
                UserName = "vahid1",
                PassWord = "123",
                NationalCode = "123456789",
                CreateDateTime = DateTime.Now,
                ExpireDateTime = Convert.ToDateTime("2025/05/05"),
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 5,
                FName = "Saeed",
                LName = "Roshani",
                UserName = "Saeed",
                PassWord = "123",
                NationalCode = "123456789",
                CreateDateTime = DateTime.Now,
                ExpireDateTime = Convert.ToDateTime("2025/05/05"),
            });
            //Electronics Category
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 6,
                FName = "Kazem",
                LName = "Rahimi",
                UserName = "Kazem",
                PassWord = "123",
                NationalCode = "123456789",
                CreateDateTime = DateTime.Now,
                ExpireDateTime = Convert.ToDateTime("2025/05/05"),
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 7,
                FName = "Ahad",
                LName = "Mohammadi",
                UserName = "Ahad",
                PassWord = "123",
                NationalCode = "123456789",
                CreateDateTime = DateTime.Now,
                ExpireDateTime = Convert.ToDateTime("2025/05/05"),
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 8,
                FName = "Shahin",
                LName = "Ahmadi",
                UserName = "Shahin",
                PassWord = "123",
                NationalCode = "123456789",
                CreateDateTime = DateTime.Now,
                ExpireDateTime = Convert.ToDateTime("2025/05/05"),
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 9,
                FName = "Hassan",
                LName = "Ahmadian",
                UserName = "Hassan",
                PassWord = "123",
                NationalCode = "123456789",
                CreateDateTime = DateTime.Now,
                ExpireDateTime = Convert.ToDateTime("2025/05/05"),
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 10,
                FName = "Mehdi",
                LName = "Khataei",
                UserName = "Mehdi",
                PassWord = "123",
                NationalCode = "123456789",
                CreateDateTime = DateTime.Now,
                ExpireDateTime = Convert.ToDateTime("2025/05/05"),
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 11,
                FName = "Mehri",
                LName = "Soltani",
                UserName = "Mehri",
                PassWord = "123",
                NationalCode = "123456789",
                CreateDateTime = DateTime.Now,
                ExpireDateTime = Convert.ToDateTime("2025/05/05"),
            });
            //Furniture Category
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 12,
                FName = "Bahar",
                LName = "Fakhim",
                UserName = "Bahar",
                PassWord = "123",
                NationalCode = "123456789",
                CreateDateTime = DateTime.Now,
                ExpireDateTime = Convert.ToDateTime("2025/05/05"),
            });

            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 13,
                FName = "Laya",
                LName = "Mostahkam",
                UserName = "Laya",
                PassWord = "123",
                NationalCode = "123456789",
                CreateDateTime = DateTime.Now,
                ExpireDateTime = Convert.ToDateTime("2025/05/05"),
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 14,
                FName = "Sajjad",
                LName = "Vosoughi",
                UserName = "Sajjad",
                PassWord = "123",
                NationalCode = "123456789",
                CreateDateTime = DateTime.Now,
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 15,
                FName = "Ali",
                LName = "Vosoughi",
                UserName = "Ali",
                PassWord = "123",
                NationalCode = "123456789",
                CreateDateTime = DateTime.Now,
                ExpireDateTime = Convert.ToDateTime("2025/05/05"),
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 16,
                FName = "Vida",
                LName = "Soltani",
                UserName = "Vida",
                PassWord = "123",
                NationalCode = "123456789",
                CreateDateTime = DateTime.Now,
                ExpireDateTime = Convert.ToDateTime("2025/05/05"),
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 17,
                FName = "Yunes",
                LName = "MohamadZadeh",
                UserName = "Yunes",
                PassWord = "123",
                NationalCode = "123456789",
                CreateDateTime = DateTime.Now,
                ExpireDateTime = Convert.ToDateTime("2025/05/05"),
            });
            //Shoes Category
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 18,
                FName = "Sahand",
                LName = "Asghari",
                UserName = "Sahand",
                PassWord = "123",
                NationalCode = "123456789",
                CreateDateTime = DateTime.Now,
                ExpireDateTime = Convert.ToDateTime("2025/05/05"),
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 19,
                FName = "Firuz",
                LName = "Kazemi",
                UserName = "Firuz",
                PassWord = "123",
                NationalCode = "123456789",
                CreateDateTime = DateTime.Now,
                ExpireDateTime = Convert.ToDateTime("2025/05/05"),
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 20,
                FName = "Mohammad",
                LName = "Shakeri",
                UserName = "Mohammad",
                PassWord = "123",
                NationalCode = "123456789",
                CreateDateTime = DateTime.Now,
                ExpireDateTime = Convert.ToDateTime("2025/05/05"),
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 21,
                FName = "Akram",
                LName = "Jahanbakhsh",
                UserName = "Akram",
                PassWord = "123",
                NationalCode = "123456789",
                CreateDateTime = DateTime.Now,
                ExpireDateTime = Convert.ToDateTime("2025/05/05"),
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 22,
                FName = "Zahra",
                LName = "Dadashzadeh",
                UserName = "Zahra",
                PassWord = "123",
                NationalCode = "123456789",
                CreateDateTime = DateTime.Now,
                ExpireDateTime = Convert.ToDateTime("2025/05/05"),
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 23,
                FName = "Davood",
                LName = "Soltani",
                UserName = "Davood",
                PassWord = "123",
                NationalCode = "123456789",
                CreateDateTime = DateTime.Now,
                ExpireDateTime = Convert.ToDateTime("2025/05/05"),
            });



        }

        public DbSet<User> Users { get; set; }

    }
}
