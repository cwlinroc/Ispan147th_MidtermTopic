using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ISpan147.Estore.SqlDataLayer.EFModel
{
	public partial class AppDbContext : DbContext
	{
		public AppDbContext()
			: base("name=AppDbContext")
		{
		}

		public virtual DbSet<Adopt> Adopts { get; set; }
		public virtual DbSet<Breed> Breeds { get; set; }
		public virtual DbSet<Category> Categories { get; set; }
		public virtual DbSet<Comment> Comments { get; set; }
		public virtual DbSet<Employee> Employees { get; set; }
		public virtual DbSet<Member> Members { get; set; }
		public virtual DbSet<Merchandise> Merchandises { get; set; }
		public virtual DbSet<OrderList> OrderLists { get; set; }
		public virtual DbSet<Order> Orders { get; set; }
		public virtual DbSet<Pet> Pets { get; set; }
		public virtual DbSet<Species> Species { get; set; }
		public virtual DbSet<Theme> Themes { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Breed>()
				.HasMany(e => e.Pets)
				.WithRequired(e => e.Breed)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Category>()
				.HasMany(e => e.Merchandises)
				.WithRequired(e => e.Category)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Member>()
				.Property(e => e.Account)
				.IsFixedLength();

			modelBuilder.Entity<Member>()
				.Property(e => e.Password)
				.IsFixedLength();

			modelBuilder.Entity<Member>()
				.Property(e => e.Phone)
				.IsFixedLength();

			modelBuilder.Entity<Member>()
				.Property(e => e.Email)
				.IsFixedLength();

			modelBuilder.Entity<Member>()
				.HasMany(e => e.Adopts)
				.WithRequired(e => e.Member)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Member>()
				.HasMany(e => e.Orders)
				.WithRequired(e => e.Member)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Merchandise>()
				.HasMany(e => e.OrderLists)
				.WithRequired(e => e.Merchandise)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Order>()
				.HasMany(e => e.OrderLists)
				.WithRequired(e => e.Order)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Pet>()
				.HasMany(e => e.Adopts)
				.WithRequired(e => e.Pet)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Species>()
				.HasMany(e => e.Breeds)
				.WithRequired(e => e.Species)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Species>()
				.HasMany(e => e.Pets)
				.WithRequired(e => e.Species)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Theme>()
				.HasMany(e => e.Comments)
				.WithRequired(e => e.Theme)
				.WillCascadeOnDelete(false);
		}
	}
}
