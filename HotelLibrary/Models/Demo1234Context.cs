using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HotelLibrary.Models;

public partial class Demo1234Context : DbContext
{
    public Demo1234Context()
    {
    }

    public Demo1234Context(DbContextOptions<Demo1234Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Bruker> Brukers { get; set; }

    public virtual DbSet<Note> Notes { get; set; }

    public virtual DbSet<Reservasjon> Reservasjons { get; set; }

    public virtual DbSet<Room> Rooms { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("data source=dat154gruppe14.database.windows.net,1433;Initial Catalog=Demo1234;user id=ingunn;password=Supphellen98;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bruker>(entity =>
        {
            entity.HasKey(e => e.PhoneNumber).HasName("PK__Bruker__85FB4E39AD043A28");

            entity.ToTable("Bruker");

            entity.Property(e => e.PhoneNumber).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TypeBruker)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Note>(entity =>
        {
            entity.HasKey(e => e.NoteId).HasName("PK__Notes__EACE355FAA4EAE64");

            entity.Property(e => e.Note1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Note");
            entity.Property(e => e.NoteType)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.RoomNumberNavigation).WithMany(p => p.Notes)
                .HasForeignKey(d => d.RoomNumber)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Notes__RoomNumbe__6B24EA82");
        });

        modelBuilder.Entity<Reservasjon>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Reservas__3214EC077831A6C6");

            entity.ToTable("Reservasjon");

            entity.Property(e => e.DatoInsjekk).HasColumnType("datetime");
            entity.Property(e => e.DatoUtsjekk).HasColumnType("datetime");

            entity.HasOne(d => d.PhoneNumberNavigation).WithMany(p => p.Reservasjons)
                .HasForeignKey(d => d.PhoneNumber)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_nummer");

            entity.HasOne(d => d.RoomNumberNavigation).WithMany(p => p.Reservasjons)
                .HasForeignKey(d => d.RoomNumber)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_room");
        });

        modelBuilder.Entity<Room>(entity =>
        {
            entity.HasKey(e => e.RoomNumber).HasName("PK__Room__AE10E07BEE2635D3");

            entity.ToTable("Room");

            entity.Property(e => e.RoomNumber).ValueGeneratedNever();
            entity.Property(e => e.Status)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
