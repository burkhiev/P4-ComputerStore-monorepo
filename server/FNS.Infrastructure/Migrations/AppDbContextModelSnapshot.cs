﻿// <auto-generated />
using System;
using FNS.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NodaTime;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FNS.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("FNS.Domain.Models.Products.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Instant>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<decimal>("Price")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric")
                        .HasDefaultValue(0m);

                    b.Property<string>("ProductCode")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)");

                    b.Property<Guid>("SubCategoryId")
                        .HasColumnType("uuid");

                    b.Property<bool>("Tumbstone")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<Instant>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<uint>("xmin")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("xid");

                    b.HasKey("Id");

                    b.HasIndex("SubCategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000001"),
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(16609377451241870L),
                            Description = "Et quo blanditiis dolor iste sint quo quo eligendi. Officia voluptatem aut qui ab sed est nihil et quae. Aliquid voluptas reprehenderit. Fugiat sed vel eveniet ullam dolores voluptas qui quia.\n\nFuga dolores iste cumque. Voluptatibus aliquam nisi quia eum perferendis. Alias omnis deserunt. Maiores voluptate quis inventore ratione dolor illo nobis assumenda. Quidem numquam eum occaecati.\n\nIpsa repellat sed quia nemo. Autem sequi et enim ut non. Autem consequuntur officiis cum assumenda ipsum. Nihil autem repellendus nisi non enim repudiandae sit.\n\nAut maxime dolorem rerum nemo reiciendis impedit qui ut. Dolorem qui deleniti iure sapiente sit. Eius sunt facilis. Dolorem libero veniam.\n\nAt aut doloribus ut eum veniam odio perferendis et laborum. At molestias pariatur et possimus esse sed omnis beatae officia. Ut earum quod voluptatibus. Quis quia et totam et asperiores eius placeat. Dolorem eos consequatur atque dolores sunt adipisci a.",
                            Name = "AMD Ryzen 5 3600 OEM",
                            Price = 12599m,
                            ProductCode = "1372637",
                            SubCategoryId = new Guid("00000000-0000-0000-0000-000000000001"),
                            Tumbstone = false,
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L)
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000002"),
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(16609377451315136L),
                            Description = "In nobis odit aliquam. Cumque a in quo autem nobis eveniet odit qui. Qui eius perspiciatis dolorum minus dolor enim. Nihil repellat eveniet eius consequatur. Dolores est quasi magni aspernatur cum aut aliquid.\n\nVoluptates nihil dicta repellendus quia nostrum asperiores ea odit. Est adipisci ut minus earum. Dolores et numquam molestiae eos consequatur vero unde. Voluptatem esse aspernatur eos.\n\nNostrum quas nobis nihil. Pariatur harum aliquid corporis dolor rerum. Sit dignissimos aut cupiditate nihil velit voluptatem quis. Rerum iste consequuntur esse quos quaerat praesentium voluptas accusantium. Tenetur voluptatibus id qui ut eos sed saepe.\n\nIpsa ratione nesciunt libero molestiae. In velit consectetur quae. Error sint sint et.\n\nError eaque similique. In ut tempora nostrum iusto sint. Unde aut laboriosam veritatis itaque. Voluptatem accusantium aliquid necessitatibus laudantium qui cumque beatae quod laboriosam. Illo velit aliquid. Velit asperiores enim numquam dolores sequi.",
                            Name = "AMD Ryzen 5 3600 BOX",
                            Price = 12899m,
                            ProductCode = "5059834",
                            SubCategoryId = new Guid("00000000-0000-0000-0000-000000000001"),
                            Tumbstone = false,
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L)
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000003"),
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(16609377451326437L),
                            Description = "Voluptatem doloribus et sit. Placeat impedit ut pariatur ut quis quo suscipit. Officia facilis doloribus est earum ullam consequuntur aut sed vitae. Voluptas est pariatur nam rerum eius alias laboriosam eligendi voluptatem. Corporis corporis et modi autem ipsum dolore voluptate. Aut aut perspiciatis.\n\nNemo ut aliquid atque atque a pariatur officia omnis harum. Ex sunt sint. Dolores sit et dolorem sint non illo.\n\nRecusandae eum ullam natus. Sint harum sit delectus dolores veniam sint voluptas. Molestias in dolor voluptatem in amet autem veniam illum aut. Perspiciatis esse soluta id amet iure.\n\nAut est non sit ut veniam et dignissimos nihil cumque. Cupiditate unde nihil ipsum qui nemo dolor. Ullam tenetur quis aut. Consequatur enim fugiat voluptatem est laborum quasi.\n\nExpedita voluptatibus non iusto. Excepturi iure eius eos dicta cupiditate amet deserunt suscipit. Facere molestiae minus iste adipisci.",
                            Name = "AMD Ryzen 5 PRO 4650G OEM",
                            Price = 12599m,
                            ProductCode = "1689358",
                            SubCategoryId = new Guid("00000000-0000-0000-0000-000000000001"),
                            Tumbstone = false,
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L)
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000004"),
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(16609377451337429L),
                            Description = "Et perspiciatis adipisci eveniet consequatur voluptatibus nesciunt. Ea pariatur porro voluptatibus perspiciatis recusandae. Officiis incidunt earum sit quaerat quisquam inventore.\n\nCupiditate ipsum itaque. Quam sunt rem voluptates et. Cum dolorem consectetur nihil sunt nisi harum dignissimos rerum. Iste blanditiis quia earum voluptatem.\n\nFacere quia ipsa consequuntur nam quam in distinctio blanditiis voluptatem. Accusamus error expedita. Assumenda magni illo numquam incidunt eligendi.\n\nEaque omnis ea. Deserunt architecto adipisci voluptas expedita laborum natus voluptatibus itaque at. Dolores voluptatem necessitatibus saepe ut repellat voluptas voluptas.\n\nDelectus perferendis consequatur aliquam ratione voluptatem vel quis aut. Vitae sint ut quam nemo. Voluptatum ipsa aspernatur soluta omnis aut molestiae. Earum veritatis assumenda rerum sed in tenetur consectetur. Pariatur ipsam quasi voluptatibus harum autem reprehenderit maxime. Facilis tenetur et ea.",
                            Name = "AMD Ryzen 5 5600X OEM",
                            Price = 16199m,
                            ProductCode = "4721161",
                            SubCategoryId = new Guid("00000000-0000-0000-0000-000000000001"),
                            Tumbstone = false,
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L)
                        });
                });

            modelBuilder.Entity("FNS.Domain.Models.Products.ProductAttribute", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ClrType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Instant>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("Measure")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<bool>("Tumbstone")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<Instant>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<uint>("xmin")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("xid");

                    b.HasKey("Id");

                    b.ToTable("ProductAttributes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000001"),
                            ClrType = "String",
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Name = "Model",
                            Tumbstone = false,
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L)
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000002"),
                            ClrType = "String",
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Name = "Socket",
                            Tumbstone = false,
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L)
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000003"),
                            ClrType = "Int32",
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Name = "Release year",
                            Tumbstone = false,
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L)
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000004"),
                            ClrType = "Int32",
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Name = "Total number of cores",
                            Tumbstone = false,
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L)
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000005"),
                            ClrType = "String",
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Name = "Maximum threads",
                            Tumbstone = false,
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L)
                        });
                });

            modelBuilder.Entity("FNS.Domain.Models.Products.ProductAttributeValue", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Instant>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("ProductAttributeId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.Property<bool>("Tumbstone")
                        .HasColumnType("boolean");

                    b.Property<Instant>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Value")
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)");

                    b.HasKey("Id");

                    b.HasIndex("ProductAttributeId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductAttributeValues");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000001"),
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            ProductAttributeId = new Guid("00000000-0000-0000-0000-000000000001"),
                            ProductId = new Guid("00000000-0000-0000-0000-000000000001"),
                            Tumbstone = false,
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Value = "AMD Ryzen 5 3600 OEM"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000002"),
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            ProductAttributeId = new Guid("00000000-0000-0000-0000-000000000002"),
                            ProductId = new Guid("00000000-0000-0000-0000-000000000001"),
                            Tumbstone = false,
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Value = "AM4"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000003"),
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            ProductAttributeId = new Guid("00000000-0000-0000-0000-000000000003"),
                            ProductId = new Guid("00000000-0000-0000-0000-000000000001"),
                            Tumbstone = false,
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Value = "2019"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000004"),
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            ProductAttributeId = new Guid("00000000-0000-0000-0000-000000000004"),
                            ProductId = new Guid("00000000-0000-0000-0000-000000000001"),
                            Tumbstone = false,
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Value = "6"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000005"),
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            ProductAttributeId = new Guid("00000000-0000-0000-0000-000000000005"),
                            ProductId = new Guid("00000000-0000-0000-0000-000000000001"),
                            Tumbstone = false,
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Value = "12"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000006"),
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            ProductAttributeId = new Guid("00000000-0000-0000-0000-000000000001"),
                            ProductId = new Guid("00000000-0000-0000-0000-000000000002"),
                            Tumbstone = false,
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Value = "AMD Ryzen 5 3600 BOX"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000007"),
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            ProductAttributeId = new Guid("00000000-0000-0000-0000-000000000002"),
                            ProductId = new Guid("00000000-0000-0000-0000-000000000002"),
                            Tumbstone = false,
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Value = "AM4"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000008"),
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            ProductAttributeId = new Guid("00000000-0000-0000-0000-000000000003"),
                            ProductId = new Guid("00000000-0000-0000-0000-000000000002"),
                            Tumbstone = false,
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Value = "2019"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000009"),
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            ProductAttributeId = new Guid("00000000-0000-0000-0000-000000000004"),
                            ProductId = new Guid("00000000-0000-0000-0000-000000000002"),
                            Tumbstone = false,
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Value = "6"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000010"),
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            ProductAttributeId = new Guid("00000000-0000-0000-0000-000000000005"),
                            ProductId = new Guid("00000000-0000-0000-0000-000000000002"),
                            Tumbstone = false,
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Value = "12"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000011"),
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            ProductAttributeId = new Guid("00000000-0000-0000-0000-000000000001"),
                            ProductId = new Guid("00000000-0000-0000-0000-000000000003"),
                            Tumbstone = false,
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Value = "AMD Ryzen 5 4650G OEM"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000012"),
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            ProductAttributeId = new Guid("00000000-0000-0000-0000-000000000002"),
                            ProductId = new Guid("00000000-0000-0000-0000-000000000003"),
                            Tumbstone = false,
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Value = "AM4"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000013"),
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            ProductAttributeId = new Guid("00000000-0000-0000-0000-000000000003"),
                            ProductId = new Guid("00000000-0000-0000-0000-000000000003"),
                            Tumbstone = false,
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Value = "2020"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000014"),
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            ProductAttributeId = new Guid("00000000-0000-0000-0000-000000000004"),
                            ProductId = new Guid("00000000-0000-0000-0000-000000000003"),
                            Tumbstone = false,
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Value = "6"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000015"),
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            ProductAttributeId = new Guid("00000000-0000-0000-0000-000000000005"),
                            ProductId = new Guid("00000000-0000-0000-0000-000000000003"),
                            Tumbstone = false,
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Value = "12"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000016"),
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            ProductAttributeId = new Guid("00000000-0000-0000-0000-000000000001"),
                            ProductId = new Guid("00000000-0000-0000-0000-000000000004"),
                            Tumbstone = false,
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Value = "AMD Ryzen 5 5600X OEM"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000017"),
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            ProductAttributeId = new Guid("00000000-0000-0000-0000-000000000002"),
                            ProductId = new Guid("00000000-0000-0000-0000-000000000004"),
                            Tumbstone = false,
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Value = "AM4"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000018"),
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            ProductAttributeId = new Guid("00000000-0000-0000-0000-000000000003"),
                            ProductId = new Guid("00000000-0000-0000-0000-000000000004"),
                            Tumbstone = false,
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Value = "2020"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000019"),
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            ProductAttributeId = new Guid("00000000-0000-0000-0000-000000000004"),
                            ProductId = new Guid("00000000-0000-0000-0000-000000000004"),
                            Tumbstone = false,
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Value = "6"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000020"),
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            ProductAttributeId = new Guid("00000000-0000-0000-0000-000000000005"),
                            ProductId = new Guid("00000000-0000-0000-0000-000000000004"),
                            Tumbstone = false,
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Value = "12"
                        });
                });

            modelBuilder.Entity("FNS.Domain.Models.Products.SubCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Instant>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<bool>("Tumbstone")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<Instant>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<uint>("xmin")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("xid");

                    b.HasKey("Id");

                    b.ToTable("SubCategories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000001"),
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Name = "Процессоры",
                            Tumbstone = false,
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L)
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000002"),
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Name = "Материские платы",
                            Tumbstone = false,
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L)
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000003"),
                            CreatedAt = NodaTime.Instant.FromUnixTimeTicks(0L),
                            Name = "Видеокарты",
                            Tumbstone = false,
                            UpdatedAt = NodaTime.Instant.FromUnixTimeTicks(0L)
                        });
                });

            modelBuilder.Entity("FNS.Domain.Models.Products.Product", b =>
                {
                    b.HasOne("FNS.Domain.Models.Products.SubCategory", "SubCategory")
                        .WithMany("Products")
                        .HasForeignKey("SubCategoryId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("SubCategory");
                });

            modelBuilder.Entity("FNS.Domain.Models.Products.ProductAttributeValue", b =>
                {
                    b.HasOne("FNS.Domain.Models.Products.ProductAttribute", "ProductAttribute")
                        .WithMany("ProductAttributeValues")
                        .HasForeignKey("ProductAttributeId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.HasOne("FNS.Domain.Models.Products.Product", "Product")
                        .WithMany("ProductAttributeValues")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("ProductAttribute");
                });

            modelBuilder.Entity("FNS.Domain.Models.Products.Product", b =>
                {
                    b.Navigation("ProductAttributeValues");
                });

            modelBuilder.Entity("FNS.Domain.Models.Products.ProductAttribute", b =>
                {
                    b.Navigation("ProductAttributeValues");
                });

            modelBuilder.Entity("FNS.Domain.Models.Products.SubCategory", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
