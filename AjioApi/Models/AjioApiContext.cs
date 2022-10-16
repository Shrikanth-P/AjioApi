﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AjioApi.Models
{
    public partial class AjioApiContext : DbContext
    {
        public AjioApiContext()
        {
        }

        public AjioApiContext(DbContextOptions<AjioApiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Registration> Registrations { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
 //               optionsBuilder.UseSqlServer("server=ELW5120\\SQLEXPRESS;database=AjioApi;Trusted_connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Registration>(entity =>
            {
                entity.ToTable("Registration");

               // entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("mobile");

                entity.Property(e => e.Password)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Useremail)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("useremail");

                entity.Property(e => e.Username)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
