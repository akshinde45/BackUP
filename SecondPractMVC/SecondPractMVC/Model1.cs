namespace SecondPractMVC
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<DEPART> DEPARTs { get; set; }
        public virtual DbSet<DEPARTMENT> DEPARTMENTs { get; set; }
        public virtual DbSet<DEPARTMENT1> DEPARTMENTS1 { get; set; }
        public virtual DbSet<EMPLOYEE> EMPLOYEEs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DEPART>()
                .Property(e => e.DEPT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<DEPART>()
                .HasMany(e => e.EMPLOYEEs)
                .WithRequired(e => e.DEPART)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DEPARTMENT>()
                .Property(e => e.DEPT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<DEPARTMENT1>()
                .Property(e => e.DEPT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.EMP_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.SALARY)
                .HasPrecision(19, 4);
        }
    }
}
