﻿// <auto-generated />
using System;
using CurriculumViewer.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CurriculumViewer.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20181010114644_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CurriculumViewer.Domain.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1024);

                    b.Property<int?>("ExamProgramId");

                    b.Property<int>("MentorId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("StudyYear");

                    b.HasKey("Id");

                    b.HasIndex("ExamProgramId");

                    b.HasIndex("MentorId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("CurriculumViewer.Domain.Models.CourseModule", b =>
                {
                    b.Property<int>("CourseId");

                    b.Property<int>("ModuleId");

                    b.HasKey("CourseId", "ModuleId");

                    b.HasIndex("ModuleId");

                    b.ToTable("CourseModules");
                });

            modelBuilder.Entity("CurriculumViewer.Domain.Models.EuropeanCompetence", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("EuropeanCompetences");
                });

            modelBuilder.Entity("CurriculumViewer.Domain.Models.Exam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AttemptOne");

                    b.Property<DateTime>("AttemptTwo");

                    b.Property<bool>("Compensatable");

                    b.Property<TimeSpan>("Duration");

                    b.Property<int>("EC");

                    b.Property<string>("ExamType")
                        .IsRequired();

                    b.Property<string>("GradeType")
                        .IsRequired();

                    b.Property<string>("Language")
                        .IsRequired();

                    b.Property<int?>("ModuleId");

                    b.Property<double>("PassingGrade");

                    b.Property<int>("ResponsibleTeacherId");

                    b.Property<double>("Weight");

                    b.HasKey("Id");

                    b.HasIndex("ModuleId");

                    b.HasIndex("ResponsibleTeacherId");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("CurriculumViewer.Domain.Models.ExamProgram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.ToTable("ExamPrograms");
                });

            modelBuilder.Entity("CurriculumViewer.Domain.Models.Goal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bloom")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(4096);

                    b.Property<int?>("ModuleId");

                    b.HasKey("Id");

                    b.HasIndex("ModuleId");

                    b.ToTable("Goals");
                });

            modelBuilder.Entity("CurriculumViewer.Domain.Models.LearningLine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("LearningLines");
                });

            modelBuilder.Entity("CurriculumViewer.Domain.Models.LearningLineGoal", b =>
                {
                    b.Property<int>("LearningLineId");

                    b.Property<int>("GoalId");

                    b.HasKey("LearningLineId", "GoalId");

                    b.HasIndex("GoalId");

                    b.ToTable("LearningLineGoals");
                });

            modelBuilder.Entity("CurriculumViewer.Domain.Models.LogItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("LogType");

                    b.Property<string>("Message");

                    b.HasKey("Id");

                    b.ToTable("LogItems");
                });

            modelBuilder.Entity("CurriculumViewer.Domain.Models.Module", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(4096);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("OsirisCode")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int?>("TeacherId");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("Modules");
                });

            modelBuilder.Entity("CurriculumViewer.Domain.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("MiddleName");

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("CurriculumViewer.Domain.Models.TeacherModule", b =>
                {
                    b.Property<int>("TeacherId");

                    b.Property<int>("ModuleId");

                    b.HasKey("TeacherId", "ModuleId");

                    b.HasIndex("ModuleId");

                    b.ToTable("TeacherModules");
                });

            modelBuilder.Entity("CurriculumViewer.Domain.Models.Course", b =>
                {
                    b.HasOne("CurriculumViewer.Domain.Models.ExamProgram")
                        .WithMany("Courses")
                        .HasForeignKey("ExamProgramId");

                    b.HasOne("CurriculumViewer.Domain.Models.Teacher", "Mentor")
                        .WithMany("ResponsibleForCourses")
                        .HasForeignKey("MentorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CurriculumViewer.Domain.Models.CourseModule", b =>
                {
                    b.HasOne("CurriculumViewer.Domain.Models.Course", "Course")
                        .WithMany("Modules")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CurriculumViewer.Domain.Models.Module", "Module")
                        .WithMany("InCourses")
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CurriculumViewer.Domain.Models.Exam", b =>
                {
                    b.HasOne("CurriculumViewer.Domain.Models.Module", "Module")
                        .WithMany("Exams")
                        .HasForeignKey("ModuleId");

                    b.HasOne("CurriculumViewer.Domain.Models.Teacher", "ResponsibleTeacher")
                        .WithMany("ResponsibleForExams")
                        .HasForeignKey("ResponsibleTeacherId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CurriculumViewer.Domain.Models.Goal", b =>
                {
                    b.HasOne("CurriculumViewer.Domain.Models.Module", "Module")
                        .WithMany("Goals")
                        .HasForeignKey("ModuleId");
                });

            modelBuilder.Entity("CurriculumViewer.Domain.Models.LearningLineGoal", b =>
                {
                    b.HasOne("CurriculumViewer.Domain.Models.Goal", "Goal")
                        .WithMany("InLearningLines")
                        .HasForeignKey("GoalId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CurriculumViewer.Domain.Models.LearningLine", "LearningLine")
                        .WithMany("Goals")
                        .HasForeignKey("LearningLineId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CurriculumViewer.Domain.Models.Module", b =>
                {
                    b.HasOne("CurriculumViewer.Domain.Models.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId");
                });

            modelBuilder.Entity("CurriculumViewer.Domain.Models.TeacherModule", b =>
                {
                    b.HasOne("CurriculumViewer.Domain.Models.Module", "Module")
                        .WithMany()
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CurriculumViewer.Domain.Models.Teacher", "Teacher")
                        .WithMany("ResponsibleForModules")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
