using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MyPortfolio.Models;

public partial class DbMyPortfolioContext : DbContext
{
    public DbMyPortfolioContext()
    {
    }

    public DbMyPortfolioContext(DbContextOptions<DbMyPortfolioContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblAbout> TblAbouts { get; set; }

    public virtual DbSet<TblCategory> TblCategories { get; set; }

    public virtual DbSet<TblContact> TblContacts { get; set; }

    public virtual DbSet<TblFeature> TblFeatures { get; set; }

    public virtual DbSet<TblProject> TblProjects { get; set; }

    public virtual DbSet<TblService> TblServices { get; set; }

    public virtual DbSet<TblSocialMedial> TblSocialMedials { get; set; }

    public virtual DbSet<TblSocialMedium> TblSocialMedia { get; set; }

    public virtual DbSet<TblTestimonial> TblTestimonials { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        => optionsBuilder.UseSqlServer("Server=DESKTOP-A6C5CRN\\MSSQLSERVER01;Database=DbMyPortfolio;Trusted_Connection=true;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblAbout>(entity =>
        {
            entity.HasKey(e => e.AboutId);

            entity.ToTable("TblAbout");

            entity.Property(e => e.AboutId).HasColumnName("AboutID");
            entity.Property(e => e.Header).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(50);
        });

        modelBuilder.Entity<TblCategory>(entity =>
        {
            entity.HasKey(e => e.CategoryId);

            entity.ToTable("TblCategory");

            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<TblContact>(entity =>
        {
            entity.HasKey(e => e.ContactId);

            entity.ToTable("TblContact");

            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.NameSurname).HasMaxLength(200);
            entity.Property(e => e.SendDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblFeature>(entity =>
        {
            entity.HasKey(e => e.FeatureId);

            entity.ToTable("TblFeature");

            entity.Property(e => e.FeatureId).HasColumnName("FeatureID");
            entity.Property(e => e.Header).HasMaxLength(50);
            entity.Property(e => e.NameSurname).HasMaxLength(100);
            entity.Property(e => e.Title).HasMaxLength(50);
        });

        modelBuilder.Entity<TblProject>(entity =>
        {
            entity.HasKey(e => e.ProjectId);

            entity.ToTable("TblProject");

            entity.Property(e => e.ProjectId).HasColumnName("ProjectID");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.Title).HasMaxLength(50);

            entity.HasOne(d => d.ProjectCategoryNavigation).WithMany(p => p.TblProjects)
                .HasForeignKey(d => d.ProjectCategory)
                .HasConstraintName("FK_TblProject_TblCategory");
        });

        modelBuilder.Entity<TblService>(entity =>
        {
            entity.HasKey(e => e.ServiceId);

            entity.ToTable("TblService");

            entity.Property(e => e.ServiceId).HasColumnName("ServiceID");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.ServiceIcon).HasMaxLength(200);
            entity.Property(e => e.Title).HasMaxLength(150);
        });

        modelBuilder.Entity<TblSocialMedial>(entity =>
        {
            entity.HasKey(e => e.SocialMediaId);

            entity.ToTable("TblSocialMedial");

            entity.Property(e => e.SocialMediaId).HasColumnName("SocialMediaID");
            entity.Property(e => e.Title).HasMaxLength(50);
        });

        modelBuilder.Entity<TblSocialMedium>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.SocialMediaId).HasColumnName("SocialMediaID");
            entity.Property(e => e.Title).HasMaxLength(50);
        });

        modelBuilder.Entity<TblTestimonial>(entity =>
        {
            entity.HasKey(e => e.TestimonialId);

            entity.ToTable("TblTestimonial");

            entity.Property(e => e.TestimonialId).HasColumnName("TestimonialID");
            entity.Property(e => e.NameSurname).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
