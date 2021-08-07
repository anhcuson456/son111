using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace eProject.Models
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<CategoryServi> CategoryServis { get; set; }
        public virtual DbSet<CategoryTour> CategoryTours { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<Img> Imgs { get; set; }
        public virtual DbSet<Servi> Servis { get; set; }
        public virtual DbSet<ServiTravel> ServiTravels { get; set; }
        public virtual DbSet<TourTravel> TourTravels { get; set; }
        public virtual DbSet<TouristSpot> TouristSpots { get; set; }
        public virtual DbSet<Travel> Travels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-LT159EB;Database=Travel_tour;user id=sa;password=1234567");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Account");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Addr)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Pass)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Rol)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CategoryServi>(entity =>
            {
                entity.ToTable("Category_Servi");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CategoryTour>(entity =>
            {
                entity.ToTable("Category_tour");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.ToTable("Comment");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccId).HasColumnName("AccID");

                entity.Property(e => e.Content)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ServiId)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("ServiID");

                entity.Property(e => e.TourId)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("TourID");

                entity.HasOne(d => d.Acc)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.AccId)
                    .HasConstraintName("FK_Comment_AccID_PK_Account_ID");

                entity.HasOne(d => d.Servi)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.ServiId)
                    .HasConstraintName("FK_Comment_ServiID_Servi_ID");

                entity.HasOne(d => d.Tour)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.TourId)
                    .HasConstraintName("FK_Comment_TourID_PK_Tourist_Spots_ID");
            });

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.ToTable("Feedback");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Addr)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Content)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Img>(entity =>
            {
                entity.ToTable("Img");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ServiId)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("ServiID");

                entity.Property(e => e.TourId)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("TourID");

                entity.HasOne(d => d.Servi)
                    .WithMany(p => p.Imgs)
                    .HasForeignKey(d => d.ServiId)
                    .HasConstraintName("FK_Img_ServiID_PK_Servi_ID");

                entity.HasOne(d => d.Tour)
                    .WithMany(p => p.Imgs)
                    .HasForeignKey(d => d.TourId)
                    .HasConstraintName("FK_Img_TourID_PK_Tourist_Spots_ID");
            });

            modelBuilder.Entity<Servi>(entity =>
            {
                entity.ToTable("Servi");

                entity.Property(e => e.Id)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.Addr)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Descrip)
                    .HasMaxLength(2500)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.TourId)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("TourID");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Servis)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Servi_CategoryID_PK_Category_Servi_ID");

                entity.HasOne(d => d.Tour)
                    .WithMany(p => p.Servis)
                    .HasForeignKey(d => d.TourId)
                    .HasConstraintName("FK_Servi_TourID_PK_Tourist_Spots_ID");
            });

            modelBuilder.Entity<ServiTravel>(entity =>
            {
                entity.ToTable("Servi_travel");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ServiId)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("ServiID");

                entity.Property(e => e.TravelId).HasColumnName("TravelID");

                entity.HasOne(d => d.Servi)
                    .WithMany(p => p.ServiTravels)
                    .HasForeignKey(d => d.ServiId)
                    .HasConstraintName("FK_Servi_travel_ServiID_Servi_ID");

                entity.HasOne(d => d.Travel)
                    .WithMany(p => p.ServiTravels)
                    .HasForeignKey(d => d.TravelId)
                    .HasConstraintName("FK_Servi_travel_TravelID_PK_Travel_ID");
            });

            modelBuilder.Entity<TourTravel>(entity =>
            {
                entity.ToTable("Tour_travel");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TourId)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("TourID");

                entity.Property(e => e.TravelId).HasColumnName("TravelID");

                entity.HasOne(d => d.Tour)
                    .WithMany(p => p.TourTravels)
                    .HasForeignKey(d => d.TourId)
                    .HasConstraintName("FK_Tour_travel_TourID_PK_Tourist_Spots_ID");

                entity.HasOne(d => d.Travel)
                    .WithMany(p => p.TourTravels)
                    .HasForeignKey(d => d.TravelId)
                    .HasConstraintName("FK_Tour_travel_TravelID_PK_Travel_ID");
            });

            modelBuilder.Entity<TouristSpot>(entity =>
            {
                entity.ToTable("Tourist_Spots");

                entity.Property(e => e.Id)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.Active)
                    .HasMaxLength(2500)
                    .IsUnicode(false);

                entity.Property(e => e.Addr)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Descrip)
                    .HasMaxLength(2500)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.TouristSpots)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Tourist_Spots_CategoryID_PK_Category_tour_ID");
            });

            modelBuilder.Entity<Travel>(entity =>
            {
                entity.ToTable("Travel");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Img)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
