using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace hajozas.Models;

public partial class HajosContext : DbContext
{
    public HajosContext()
    {
    }

    public HajosContext(DbContextOptions<HajosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Question> Questions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=bit.uni-corvinus.hu;Initial Catalog=hajos;Persist Security Info=True;User ID=hallgato;Password=Password123;Encrypt=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Question>(entity =>
        {
            entity.ToTable("Question");

            entity.Property(e => e.QuestionId)
                .ValueGeneratedNever()
                .HasColumnName("Question_ID");
            entity.Property(e => e.Question1).HasColumnName("Question");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
