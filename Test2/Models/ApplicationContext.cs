using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Test2.Models
{
    public partial class ApplicationContext : DbContext
    {
        public ApplicationContext()
            : base("name=ApplicationContext")
        {
        }

        public virtual DbSet<Activities> Activities { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Product> Events { get; set; }
        public virtual DbSet<Exhibitors> Exhibitors { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<Jury> Jury { get; set; }
        public virtual DbSet<Moderators> Moderators { get; set; }
        public virtual DbSet<Organizers> Organizers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Activities>()
                .Property(e => e.Activity)
                .IsUnicode(false);

            modelBuilder.Entity<City>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Countries>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Countries>()
                .Property(e => e.EnglishName)
                .IsUnicode(false);

            modelBuilder.Entity<Countries>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Countries>()
                .Property(e => e.Code2)
                .IsUnicode(false);

            modelBuilder.Entity<Countries>()
                .HasMany(e => e.Exhibitors)
                .WithOptional(e => e.Countries)
                .HasForeignKey(e => e.Country);

            modelBuilder.Entity<Countries>()
                .HasMany(e => e.Jury)
                .WithOptional(e => e.Countries)
                .HasForeignKey(e => e.Country);

            modelBuilder.Entity<Countries>()
                .HasMany(e => e.Moderators)
                .WithOptional(e => e.Countries)
                .HasForeignKey(e => e.Country);

            modelBuilder.Entity<Countries>()
                .HasMany(e => e.Organizers)
                .WithOptional(e => e.Countries)
                .HasForeignKey(e => e.Country);

            modelBuilder.Entity<Product>()
                .Property(e => e.Event)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Photo)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Activities)
                .WithOptional(e => e.Events)
                .HasForeignKey(e => e.EventID);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Jury)
                .WithOptional(e => e.Events)
                .HasForeignKey(e => e.EventID);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Moderators)
                .WithOptional(e => e.Events)
                .HasForeignKey(e => e.EventID);

            modelBuilder.Entity<Exhibitors>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Exhibitors>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Exhibitors>()
                .Property(e => e.Patronymic)
                .IsUnicode(false);

            modelBuilder.Entity<Exhibitors>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Exhibitors>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Exhibitors>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Exhibitors>()
                .Property(e => e.Photo)
                .IsUnicode(false);

            modelBuilder.Entity<Exhibitors>()
                .Property(e => e.Gender)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Gender>()
                .Property(e => e.Code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Gender>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Gender>()
                .HasMany(e => e.Exhibitors)
                .WithOptional(e => e.Gender1)
                .HasForeignKey(e => e.Gender);

            modelBuilder.Entity<Gender>()
                .HasMany(e => e.Jury)
                .WithOptional(e => e.Gender1)
                .HasForeignKey(e => e.Gender);

            modelBuilder.Entity<Gender>()
                .HasMany(e => e.Moderators)
                .WithOptional(e => e.Gender1)
                .HasForeignKey(e => e.Gender);

            modelBuilder.Entity<Gender>()
                .HasMany(e => e.Organizers)
                .WithOptional(e => e.Gender1)
                .HasForeignKey(e => e.Gender);

            modelBuilder.Entity<Jury>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Jury>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Jury>()
                .Property(e => e.Patronymic)
                .IsUnicode(false);

            modelBuilder.Entity<Jury>()
                .Property(e => e.Gender)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Jury>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Jury>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Jury>()
                .Property(e => e.Direction)
                .IsUnicode(false);

            modelBuilder.Entity<Jury>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Jury>()
                .Property(e => e.Photo)
                .IsUnicode(false);

            modelBuilder.Entity<Moderators>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Moderators>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Moderators>()
                .Property(e => e.Patronymic)
                .IsUnicode(false);

            modelBuilder.Entity<Moderators>()
                .Property(e => e.Gender)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Moderators>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Moderators>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Moderators>()
                .Property(e => e.Direction)
                .IsUnicode(false);

            modelBuilder.Entity<Moderators>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Moderators>()
                .Property(e => e.Photo)
                .IsUnicode(false);

            modelBuilder.Entity<Moderators>()
                .HasMany(e => e.Activities)
                .WithOptional(e => e.Moderators)
                .HasForeignKey(e => e.Moderator);

            modelBuilder.Entity<Organizers>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Organizers>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Organizers>()
                .Property(e => e.Patronymic)
                .IsUnicode(false);

            modelBuilder.Entity<Organizers>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Organizers>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Organizers>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Organizers>()
                .Property(e => e.Photo)
                .IsUnicode(false);

            modelBuilder.Entity<Organizers>()
                .Property(e => e.Gender)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
