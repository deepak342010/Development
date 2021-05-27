﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Models;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(TestDbContext))]
    [Migration("20210526064627_migration3")]
    partial class migration3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication1.Models.TblCatchword", b =>
                {
                    b.Property<int>("IN_CATCHWORD_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("B_PROMPT")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("DT_LASTUPDATED_ON")
                        .HasColumnType("datetime2");

                    b.Property<int>("IN_LASTUPDATED_BY")
                        .HasColumnType("int");

                    b.Property<int>("IN_TYPE")
                        .HasColumnType("int");

                    b.Property<int>("TI_CATCHWORD_ORDER")
                        .HasColumnType("int");

                    b.Property<string>("VC_CATCHWORD")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IN_CATCHWORD_ID");

                    b.ToTable("TBL_CATCHWORD");
                });

            modelBuilder.Entity("WebApplication1.Models.TblCategory", b =>
                {
                    b.Property<int>("IN_CATEGORY_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("B_PROMPT")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("DT_LASTUPDATED_ON")
                        .HasColumnType("datetime2");

                    b.Property<int>("IN_LASTUPDATED_BY")
                        .HasColumnType("int");

                    b.Property<int?>("IN_PROCESS_ID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("IN_SEQUENCE")
                        .HasColumnType("int");

                    b.Property<string>("VC_CATEGORY_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IN_CATEGORY_ID");

                    b.HasIndex("IN_PROCESS_ID");

                    b.ToTable("TBL_CATEGORY");
                });

            modelBuilder.Entity("WebApplication1.Models.TblProcess", b =>
                {
                    b.Property<int>("IN_PROCESS_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DT_LASTUPDATED_ON")
                        .HasColumnType("datetime2");

                    b.Property<int>("IN_LASTUPDATED_By")
                        .HasColumnType("int");

                    b.Property<int>("IN_LAST_SEQ")
                        .HasColumnType("int");

                    b.Property<string>("VC_PROCESS_NAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IN_PROCESS_ID");

                    b.ToTable("TBL_PROCESS");
                });

            modelBuilder.Entity("WebApplication1.Models.TblQueue", b =>
                {
                    b.Property<int>("IN_QUEUE_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("IN_PROCESS_ID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("VC_QUEUE_NAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IN_QUEUE_ID");

                    b.HasIndex("IN_PROCESS_ID");

                    b.ToTable("TBL_QUEUE");
                });

            modelBuilder.Entity("WebApplication1.Models.TblCategory", b =>
                {
                    b.HasOne("WebApplication1.Models.TblProcess", "TblProcess")
                        .WithMany()
                        .HasForeignKey("IN_PROCESS_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TblProcess");
                });

            modelBuilder.Entity("WebApplication1.Models.TblQueue", b =>
                {
                    b.HasOne("WebApplication1.Models.TblProcess", "TblProcess")
                        .WithMany()
                        .HasForeignKey("IN_PROCESS_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TblProcess");
                });
#pragma warning restore 612, 618
        }
    }
}
