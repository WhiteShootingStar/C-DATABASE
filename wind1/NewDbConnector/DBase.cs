namespace wind1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBase : DbContext
    {
        public DBase()
            : base("name=DBase")
        {
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Student_Subject> Student_Subject { get; set; }
        public virtual DbSet<Study> Studies { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasMany(e => e.Student_Subject)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Study>()
                .HasMany(e => e.Students)
                .WithRequired(e => e.Study)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Subject>()
                .HasMany(e => e.Student_Subject)
                .WithRequired(e => e.Subject)
                .WillCascadeOnDelete(false);
        }
    }
}
