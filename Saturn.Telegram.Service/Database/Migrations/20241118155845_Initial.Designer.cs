﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Saturn.Bot.Service.Database;

#nullable disable

namespace Saturn.Bot.Service.Database.Migrations
{
    [DbContext(typeof(SaturnContext))]
    [Migration("20241118155845_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Saturn.Bot.Service.Database.Entities.MessageEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<long>("ChatId")
                        .HasColumnType("bigint");

                    b.Property<string>("ChatName")
                        .HasColumnType("text");

                    b.Property<int>("ChatType")
                        .HasColumnType("integer");

                    b.Property<string>("FromFirstName")
                        .HasColumnType("text");

                    b.Property<string>("FromLastName")
                        .HasColumnType("text");

                    b.Property<long?>("FromUserId")
                        .HasColumnType("bigint");

                    b.Property<string>("FromUsername")
                        .HasColumnType("text");

                    b.Property<DateTime>("MessageDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("StickerId")
                        .HasColumnType("text");

                    b.Property<string>("Text")
                        .HasColumnType("text");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.Property<string>("UpdateData")
                        .IsRequired()
                        .HasColumnType("jsonb");

                    b.HasKey("Id");

                    b.HasIndex("ChatId");

                    b.HasIndex("FromUserId");

                    b.ToTable("Messages");
                });
#pragma warning restore 612, 618
        }
    }
}