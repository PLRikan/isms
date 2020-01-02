using ismsapi.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ismsapi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<Admin> UserAdmins { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<EducateType> EducateTypes { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventStatus> EventStatuses { get; set; }
        public DbSet<EventBooking> EventBookings { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Lecturer> Lectures { get; set; }
        public DbSet<MajorLecturer> MajorLectures { get; set; }
        public DbSet<MajorStudent> MajorStudents { get; set; }
        public DbSet<Models.Options> Options { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostStatus> PostStatuses { get; set; }
        public DbSet<RoleAction> RoleActions { get; set; }
        public DbSet<RoleDetail> RoleDetails { get; set; }
        public DbSet<RoleGroup> RoleGroups { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudyStatus> StudyStatuses { get; set; }
        public DbSet<StudyType> StudyTypes { get; set; }
        public DbSet<TutionStatus> TutionStatuses { get; set; }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);

        //    builder.Entity<UserRole>(userRole =>
        //    {
        //        userRole.HasKey(ur => new { ur.UserId, ur.RoleId });

        //        userRole.HasOne(ur => ur.Role)
        //            .WithMany(r => r.UserRoles)
        //            .HasForeignKey(ur => ur.RoleId)
        //            .IsRequired();

        //        userRole.HasOne(ur => ur.AppUser)
        //            .WithMany(r => r.UserRoles)
        //            .HasForeignKey(ur => ur.UserId)
        //            .IsRequired();
        //    });

        //    builder.Entity<CategoryPost>(categoryPost =>
        //   {
        //       categoryPost.HasKey(cp => new { cp.PostId, cp.CategoryId });

        //       categoryPost.HasOne(cp => cp.Post)
        //           .WithMany(p => p.CategoryPosts)
        //           .HasForeignKey(p => p.PostId)
        //           .IsRequired();

        //       categoryPost.HasOne(cp => cp.Category)
        //           .WithMany(c => c.CategoryPosts)
        //           .HasForeignKey(c => c.CategoryId)
        //           .IsRequired();
        //   });
        //}
    }
}
