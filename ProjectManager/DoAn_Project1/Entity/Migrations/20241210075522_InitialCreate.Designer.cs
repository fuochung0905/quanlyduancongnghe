﻿// <auto-generated />
using System;
using Entity.DBContent;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Entity.Migrations
{
    [DbContext(typeof(DoAnProject1Context))]
    [Migration("20241210075522_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entity.DBContent.PHANQUYEN", b =>
                {
                    b.Property<string>("ControllerName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsCapNhat")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDuyet")
                        .HasColumnType("bit");

                    b.Property<bool>("IsThongKe")
                        .HasColumnType("bit");

                    b.Property<bool>("IsXem")
                        .HasColumnType("bit");

                    b.Property<bool>("IsXoa")
                        .HasColumnType("bit");

                    b.Property<Guid>("VaiTroId")
                        .HasColumnType("uniqueidentifier");

                    b.ToTable("PHANQUYEN", (string)null);
                });

            modelBuilder.Entity("Entity.DBContent.PHANQUYEN_NHOMQUYEN", b =>
                {
                    b.Property<string>("Icon")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActived")
                        .HasColumnType("bit");

                    b.Property<int>("Sort")
                        .HasColumnType("int");

                    b.Property<string>("TenGoi")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.ToTable("PHANQUYEN_NHOMQUYEN", (string)null);
                });

            modelBuilder.Entity("Entity.DBContent.SYS_MENU", b =>
                {
                    b.Property<string>("Action")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("CoCapNhat")
                        .HasColumnType("bit");

                    b.Property<bool>("CoDuyet")
                        .HasColumnType("bit");

                    b.Property<bool>("CoThem")
                        .HasColumnType("bit");

                    b.Property<bool>("CoThongKe")
                        .HasColumnType("bit");

                    b.Property<bool>("CoXem")
                        .HasColumnType("bit");

                    b.Property<bool>("CoXoa")
                        .HasColumnType("bit");

                    b.Property<string>("Controller")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("ControllerName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("IsActived")
                        .HasColumnType("bit");

                    b.Property<bool>("IsShowMenu")
                        .HasColumnType("bit");

                    b.Property<Guid>("NhomQuyenId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Sort")
                        .HasColumnType("int");

                    b.Property<string>("TenGoi")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.ToTable("SYS_MENU", (string)null);
                });

            modelBuilder.Entity("Entity.DBContent.TAIKHOAN", b =>
                {
                    b.Property<string>("AnhDaiDien")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<Guid?>("DonViId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .IsUnicode(false)
                        .HasColumnType("varchar(256)");

                    b.Property<int>("GioiTinh")
                        .HasColumnType("int");

                    b.Property<string>("HoLot")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<Guid?>("HuyenId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActived")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("MatKhauSalt")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("NgaySinh")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("NgaySua")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("NgayXoa")
                        .HasColumnType("datetime");

                    b.Property<Guid?>("NguoiQuanLyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NguoiSua")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NguoiTao")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NguoiXoa")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<Guid?>("PhongBanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SoDienThoai")
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid?>("TinhId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<Guid>("VaiTroId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("XaId")
                        .HasColumnType("uniqueidentifier");

                    b.ToTable("TAIKHOAN", (string)null);
                });

            modelBuilder.Entity("Entity.DBContent.VAITRO", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActived")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("NgaySua")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("NgayXoa")
                        .HasColumnType("datetime");

                    b.Property<string>("NguoSua")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NguoiTao")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NguoiXoa")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("TenGoi")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.ToTable("VAITRO", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
