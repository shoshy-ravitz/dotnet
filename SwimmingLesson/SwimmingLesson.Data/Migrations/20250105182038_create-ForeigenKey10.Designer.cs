﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SwimmingLesson.Data;

#nullable disable

namespace SwimmingLesson.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20250105182038_create-ForeigenKey10")]
    partial class createForeigenKey10
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.36")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CourseGuide", b =>
                {
                    b.Property<int>("CoursesCodeCourse")
                        .HasColumnType("int");

                    b.Property<int>("guidesId")
                        .HasColumnType("int");

                    b.HasKey("CoursesCodeCourse", "guidesId");

                    b.HasIndex("guidesId");

                    b.ToTable("CourseGuide");
                });

            modelBuilder.Entity("GroupStudent", b =>
                {
                    b.Property<int>("GroupsCodeGroup")
                        .HasColumnType("int");

                    b.Property<int>("StudentsCodeStudent")
                        .HasColumnType("int");

                    b.HasKey("GroupsCodeGroup", "StudentsCodeStudent");

                    b.HasIndex("StudentsCodeStudent");

                    b.ToTable("GroupStudent");
                });

            modelBuilder.Entity("SwimmingLessons.Entities.Course", b =>
                {
                    b.Property<int>("CodeCourse")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodeCourse"), 1L, 1);

                    b.Property<int>("CountLessons")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("CodeCourse");

                    b.ToTable("course");
                });

            modelBuilder.Entity("SwimmingLessons.Entities.Group", b =>
                {
                    b.Property<int>("CodeGroup")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodeGroup"), 1L, 1);

                    b.Property<int>("CodeCourse")
                        .HasColumnType("int");

                    b.Property<int>("CodeGuide")
                        .HasColumnType("int");

                    b.Property<int>("CodeStudent")
                        .HasColumnType("int");

                    b.Property<int>("CountStudent")
                        .HasColumnType("int");

                    b.Property<int>("MaxStudent")
                        .HasColumnType("int");

                    b.HasKey("CodeGroup");

                    b.HasIndex("CodeCourse");

                    b.HasIndex("CodeGuide");

                    b.ToTable("group");
                });

            modelBuilder.Entity("SwimmingLessons.Entities.Guide", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.Property<int>("Seniority")
                        .HasColumnType("int");

                    b.Property<string>("Tz")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Guides");
                });

            modelBuilder.Entity("SwimmingLessons.Entities.Lesson", b =>
                {
                    b.Property<int>("CodeLesson")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodeLesson"), 1L, 1);

                    b.Property<DateTime?>("DateLesson")
                        .HasColumnType("datetime2");

                    b.Property<bool>("FreeSwimming")
                        .HasColumnType("bit");

                    b.Property<int?>("GroupCodeGroup")
                        .HasColumnType("int");

                    b.Property<string>("LearntInLesson")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumLesson")
                        .HasColumnType("int");

                    b.Property<DateTime?>("TimeEndLesson")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("TimeStartLesson")
                        .HasColumnType("datetime2");

                    b.HasKey("CodeLesson");

                    b.HasIndex("GroupCodeGroup");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("SwimmingLessons.Entities.Student", b =>
                {
                    b.Property<int>("CodeStudent")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodeStudent"), 1L, 1);

                    b.Property<DateTime>("DateBirth")
                        .HasColumnType("datetime2");

                    b.Property<int>("HealthFund")
                        .HasColumnType("int");

                    b.Property<double>("Mark")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("ProofPayment")
                        .HasColumnType("int");

                    b.Property<string>("Tz")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CodeStudent");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("CourseGuide", b =>
                {
                    b.HasOne("SwimmingLessons.Entities.Course", null)
                        .WithMany()
                        .HasForeignKey("CoursesCodeCourse")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SwimmingLessons.Entities.Guide", null)
                        .WithMany()
                        .HasForeignKey("guidesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GroupStudent", b =>
                {
                    b.HasOne("SwimmingLessons.Entities.Group", null)
                        .WithMany()
                        .HasForeignKey("GroupsCodeGroup")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SwimmingLessons.Entities.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentsCodeStudent")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SwimmingLessons.Entities.Group", b =>
                {
                    b.HasOne("SwimmingLessons.Entities.Course", "Course")
                        .WithMany("Groups")
                        .HasForeignKey("CodeCourse")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SwimmingLessons.Entities.Guide", "Guide")
                        .WithMany("Groups")
                        .HasForeignKey("CodeGuide")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Guide");
                });

            modelBuilder.Entity("SwimmingLessons.Entities.Lesson", b =>
                {
                    b.HasOne("SwimmingLessons.Entities.Group", null)
                        .WithMany("Lessons")
                        .HasForeignKey("GroupCodeGroup");
                });

            modelBuilder.Entity("SwimmingLessons.Entities.Course", b =>
                {
                    b.Navigation("Groups");
                });

            modelBuilder.Entity("SwimmingLessons.Entities.Group", b =>
                {
                    b.Navigation("Lessons");
                });

            modelBuilder.Entity("SwimmingLessons.Entities.Guide", b =>
                {
                    b.Navigation("Groups");
                });
#pragma warning restore 612, 618
        }
    }
}
