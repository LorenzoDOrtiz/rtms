﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RTMS.Plugins.PostgreEFCore;

#nullable disable

namespace RTMS.Plugins.PostgreEFCore.Migrations
{
    [DbContext(typeof(RTMSDBContext))]
    [Migration("20240912225523_UpdateExerciseModelToTrackExerciseTemplateId")]
    partial class UpdateExerciseModelToTrackExerciseTemplateId
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("RTMS.CoreBusiness.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("ExerciseTemplateId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Note")
                        .HasColumnType("text");

                    b.Property<string>("RestTimerUnit")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("RestTimerValue")
                        .HasColumnType("integer");

                    b.Property<int>("WorkoutId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseTemplateId");

                    b.HasIndex("WorkoutId");

                    b.ToTable("Exercises");
                });

            modelBuilder.Entity("RTMS.CoreBusiness.ExerciseSet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ExerciseId")
                        .HasColumnType("integer");

                    b.Property<int>("Reps")
                        .HasColumnType("integer");

                    b.Property<double>("Weight")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseId");

                    b.ToTable("ExerciseSets");
                });

            modelBuilder.Entity("RTMS.CoreBusiness.ExerciseSetTemplate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ExerciseTemplateId")
                        .HasColumnType("integer");

                    b.Property<int>("Reps")
                        .HasColumnType("integer");

                    b.Property<double>("Weight")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseTemplateId");

                    b.ToTable("ExerciseSetTemplates");
                });

            modelBuilder.Entity("RTMS.CoreBusiness.ExerciseTemplate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Note")
                        .HasColumnType("text");

                    b.Property<int>("Order")
                        .HasColumnType("integer");

                    b.Property<string>("RestTimerUnit")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("RestTimerValue")
                        .HasColumnType("integer");

                    b.Property<int>("WorkoutTemplateId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("WorkoutTemplateId");

                    b.ToTable("ExerciseTemplates");
                });

            modelBuilder.Entity("RTMS.CoreBusiness.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("RTMS.CoreBusiness.UserLogin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Provider")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("Provider", "ProviderKey")
                        .IsUnique();

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("RTMS.CoreBusiness.Workout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("TemplateId")
                        .HasColumnType("integer");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("TemplateId");

                    b.HasIndex("UserId");

                    b.ToTable("Workouts");
                });

            modelBuilder.Entity("RTMS.CoreBusiness.WorkoutTemplate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("WorkoutTemplates");
                });

            modelBuilder.Entity("RTMS.CoreBusiness.Exercise", b =>
                {
                    b.HasOne("RTMS.CoreBusiness.ExerciseTemplate", "ExerciseTemplate")
                        .WithMany()
                        .HasForeignKey("ExerciseTemplateId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("RTMS.CoreBusiness.Workout", "Workout")
                        .WithMany("Exercises")
                        .HasForeignKey("WorkoutId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ExerciseTemplate");

                    b.Navigation("Workout");
                });

            modelBuilder.Entity("RTMS.CoreBusiness.ExerciseSet", b =>
                {
                    b.HasOne("RTMS.CoreBusiness.Exercise", "Exercise")
                        .WithMany("Sets")
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exercise");
                });

            modelBuilder.Entity("RTMS.CoreBusiness.ExerciseSetTemplate", b =>
                {
                    b.HasOne("RTMS.CoreBusiness.ExerciseTemplate", null)
                        .WithMany("Sets")
                        .HasForeignKey("ExerciseTemplateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RTMS.CoreBusiness.ExerciseTemplate", b =>
                {
                    b.HasOne("RTMS.CoreBusiness.WorkoutTemplate", null)
                        .WithMany("Exercises")
                        .HasForeignKey("WorkoutTemplateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RTMS.CoreBusiness.UserLogin", b =>
                {
                    b.HasOne("RTMS.CoreBusiness.User", "User")
                        .WithMany("UserLogins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("RTMS.CoreBusiness.Workout", b =>
                {
                    b.HasOne("RTMS.CoreBusiness.WorkoutTemplate", "Template")
                        .WithMany()
                        .HasForeignKey("TemplateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RTMS.CoreBusiness.User", "User")
                        .WithMany("Workouts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Template");

                    b.Navigation("User");
                });

            modelBuilder.Entity("RTMS.CoreBusiness.WorkoutTemplate", b =>
                {
                    b.HasOne("RTMS.CoreBusiness.User", "User")
                        .WithMany("WorkoutTemplates")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("RTMS.CoreBusiness.Exercise", b =>
                {
                    b.Navigation("Sets");
                });

            modelBuilder.Entity("RTMS.CoreBusiness.ExerciseTemplate", b =>
                {
                    b.Navigation("Sets");
                });

            modelBuilder.Entity("RTMS.CoreBusiness.User", b =>
                {
                    b.Navigation("UserLogins");

                    b.Navigation("WorkoutTemplates");

                    b.Navigation("Workouts");
                });

            modelBuilder.Entity("RTMS.CoreBusiness.Workout", b =>
                {
                    b.Navigation("Exercises");
                });

            modelBuilder.Entity("RTMS.CoreBusiness.WorkoutTemplate", b =>
                {
                    b.Navigation("Exercises");
                });
#pragma warning restore 612, 618
        }
    }
}