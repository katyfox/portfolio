﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using portfolio.Models;

namespace portfolio.Migrations
{
    [DbContext(typeof(BlogContext))]
    partial class BlogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("portfolio.Models.BlogPost", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author");

                    b.Property<string>("Content");

                    b.Property<DateTime>("Date");

                    b.Property<string>("ImagePath");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("BlogPosts");
                });

            modelBuilder.Entity("portfolio.Models.BlogPostBlogPostTag", b =>
                {
                    b.Property<Guid>("BlogPostId");

                    b.Property<Guid>("BlogPostTagId");

                    b.HasKey("BlogPostId", "BlogPostTagId");

                    b.HasIndex("BlogPostTagId");

                    b.ToTable("BlogPostBlogPostTag");
                });

            modelBuilder.Entity("portfolio.Models.BlogPostTag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("TagName");

                    b.HasKey("Id");

                    b.ToTable("BlogPostTags");
                });

            modelBuilder.Entity("portfolio.Models.BlogPostBlogPostTag", b =>
                {
                    b.HasOne("portfolio.Models.BlogPost", "BlogPost")
                        .WithMany("BlogPostTags")
                        .HasForeignKey("BlogPostId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("portfolio.Models.BlogPostTag", "BlogPostTag")
                        .WithMany("BlogPostsTags")
                        .HasForeignKey("BlogPostTagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
