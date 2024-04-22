﻿// <auto-generated />
using System;
using Attendance_Time_Tracking.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Attendance_Time_Tracking.Migrations
{
    [DbContext(typeof(AttendanceContext))]
    [Migration("20240403074311_fix2")]
    partial class fix2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Attendance_Time_Tracking.Models.Attendance", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Arrival_Time")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Departure_Time")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "Date");

                    b.ToTable("Attendances");
                });

            modelBuilder.Entity("Attendance_Time_Tracking.Models.Intake", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProgramID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ProgramID");

                    b.ToTable("Intakes");
                });

            modelBuilder.Entity("Attendance_Time_Tracking.Models.Permission", b =>
                {
                    b.Property<int>("StdId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int?>("SupId")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("StdId", "Date");

                    b.HasIndex("SupId");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("Attendance_Time_Tracking.Models.Programs", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Programs");
                });

            modelBuilder.Entity("Attendance_Time_Tracking.Models.Schedule", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("End_Time")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Start_Time")
                        .HasColumnType("datetime2");

                    b.Property<int?>("SupId")
                        .HasColumnType("int");

                    b.Property<int>("TrackId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("SupId");

                    b.HasIndex("TrackId");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("Attendance_Time_Tracking.Models.Track", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("IntakeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("SupID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IntakeId");

                    b.HasIndex("SupID");

                    b.ToTable("Tracks");
                });

            modelBuilder.Entity("Attendance_Time_Tracking.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Users");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("Attendance_Time_Tracking.Models.Employee", b =>
                {
                    b.HasBaseType("Attendance_Time_Tracking.Models.User");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasIndex("UserID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Attendance_Time_Tracking.Models.Instructor", b =>
                {
                    b.HasBaseType("Attendance_Time_Tracking.Models.User");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("Attendance_Time_Tracking.Models.Student", b =>
                {
                    b.HasBaseType("Attendance_Time_Tracking.Models.User");

                    b.Property<string>("Faculty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("Graduation_year")
                        .HasColumnType("date");

                    b.Property<string>("Specialization")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrackId")
                        .HasColumnType("int");

                    b.Property<string>("University")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("TrackId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Attendance_Time_Tracking.Models.Attendance", b =>
                {
                    b.HasOne("Attendance_Time_Tracking.Models.User", "User")
                        .WithMany("Attendances")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Attendance_Time_Tracking.Models.Intake", b =>
                {
                    b.HasOne("Attendance_Time_Tracking.Models.Programs", "Program")
                        .WithMany("ProgramIntakes")
                        .HasForeignKey("ProgramID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Program");
                });

            modelBuilder.Entity("Attendance_Time_Tracking.Models.Permission", b =>
                {
                    b.HasOne("Attendance_Time_Tracking.Models.Student", "Student")
                        .WithMany("Permissions")
                        .HasForeignKey("StdId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("Attendance_Time_Tracking.Models.Instructor", "Supervisor")
                        .WithMany("Permissions")
                        .HasForeignKey("SupId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Student");

                    b.Navigation("Supervisor");
                });

            modelBuilder.Entity("Attendance_Time_Tracking.Models.Schedule", b =>
                {
                    b.HasOne("Attendance_Time_Tracking.Models.Instructor", "Supervisor")
                        .WithMany("Schedules")
                        .HasForeignKey("SupId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Attendance_Time_Tracking.Models.Track", "Track")
                        .WithMany("Schedules")
                        .HasForeignKey("TrackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Supervisor");

                    b.Navigation("Track");
                });

            modelBuilder.Entity("Attendance_Time_Tracking.Models.Track", b =>
                {
                    b.HasOne("Attendance_Time_Tracking.Models.Intake", "Intake")
                        .WithMany("Tracks")
                        .HasForeignKey("IntakeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Attendance_Time_Tracking.Models.Instructor", "Supervisor")
                        .WithMany("Tracks")
                        .HasForeignKey("SupID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Intake");

                    b.Navigation("Supervisor");
                });

            modelBuilder.Entity("Attendance_Time_Tracking.Models.Employee", b =>
                {
                    b.HasOne("Attendance_Time_Tracking.Models.User", null)
                        .WithOne()
                        .HasForeignKey("Attendance_Time_Tracking.Models.Employee", "ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Attendance_Time_Tracking.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Attendance_Time_Tracking.Models.Instructor", b =>
                {
                    b.HasOne("Attendance_Time_Tracking.Models.User", null)
                        .WithOne()
                        .HasForeignKey("Attendance_Time_Tracking.Models.Instructor", "ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Attendance_Time_Tracking.Models.Student", b =>
                {
                    b.HasOne("Attendance_Time_Tracking.Models.User", null)
                        .WithOne()
                        .HasForeignKey("Attendance_Time_Tracking.Models.Student", "ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Attendance_Time_Tracking.Models.Track", "Track")
                        .WithMany("Instructors")
                        .HasForeignKey("TrackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Track");
                });

            modelBuilder.Entity("Attendance_Time_Tracking.Models.Intake", b =>
                {
                    b.Navigation("Tracks");
                });

            modelBuilder.Entity("Attendance_Time_Tracking.Models.Programs", b =>
                {
                    b.Navigation("ProgramIntakes");
                });

            modelBuilder.Entity("Attendance_Time_Tracking.Models.Track", b =>
                {
                    b.Navigation("Instructors");

                    b.Navigation("Schedules");
                });

            modelBuilder.Entity("Attendance_Time_Tracking.Models.User", b =>
                {
                    b.Navigation("Attendances");
                });

            modelBuilder.Entity("Attendance_Time_Tracking.Models.Instructor", b =>
                {
                    b.Navigation("Permissions");

                    b.Navigation("Schedules");

                    b.Navigation("Tracks");
                });

            modelBuilder.Entity("Attendance_Time_Tracking.Models.Student", b =>
                {
                    b.Navigation("Permissions");
                });
#pragma warning restore 612, 618
        }
    }
}
