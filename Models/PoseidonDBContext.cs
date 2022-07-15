using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApi.Models
{
    public partial class PoseidonDBContext : DbContext
    {
        public PoseidonDBContext()
        {
        }

        public PoseidonDBContext(DbContextOptions<PoseidonDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bids> Bids { get; set; }
        public virtual DbSet<CurvePoints> CurvePoints { get; set; }
        public virtual DbSet<Ratings> Ratings { get; set; }
        public virtual DbSet<Rules> Rules { get; set; }
        public virtual DbSet<Trades> Trades { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=PoseidonDB;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Bids>(entity =>
            {
                entity.HasKey(e => e.BidId)
                    .HasName("PK__Bids__4A733D92A9D5CDC4");

                entity.Property(e => e.Account)
                    .IsRequired()
                    .HasColumnName("account")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ask).HasColumnName("ask");

                entity.Property(e => e.AskQuantity).HasColumnName("askQuantity");

                entity.Property(e => e.Benchmark)
                    .HasColumnName("benchmark")
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.Bid).HasColumnName("bid");

                entity.Property(e => e.BidDate)
                    .HasColumnName("bidDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.BidQuantity).HasColumnName("bidQuantity");

                entity.Property(e => e.Book)
                    .HasColumnName("book")
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.Commentary)
                    .HasColumnName("commentary")
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreationName)
                    .HasColumnName("creationName")
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.DealName)
                    .HasColumnName("dealName")
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.DealType)
                    .HasColumnName("dealType")
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.RevisionDate)
                    .HasColumnName("revisionDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.RevisionName)
                    .HasColumnName("revisionName")
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.Security)
                    .HasColumnName("security")
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.Side)
                    .HasColumnName("side")
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.SourceListId)
                    .HasColumnName("sourceListId")
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Trader)
                    .HasColumnName("trader")
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CurvePoints>(entity =>
            {
                entity.HasKey(e => e.CurvePointId)
                    .HasName("PK__CurvePoi__1BF9A575E5E4258B");

                entity.Property(e => e.AsOfDate)
                    .HasColumnName("asOfDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Term).HasColumnName("term");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<Ratings>(entity =>
            {
                entity.HasKey(e => e.RatingId)
                    .HasName("PK__Ratings__FCCDF87C4ACBAA02");

                entity.Property(e => e.FitchRating)
                    .HasColumnName("fitchRating")
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.MoodysRating)
                    .HasColumnName("moodysRating")
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNumber).HasColumnName("orderNumber");

                entity.Property(e => e.SandPrating)
                    .HasColumnName("sandPRating")
                    .HasMaxLength(125)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Rules>(entity =>
            {
                entity.HasKey(e => e.RuleId)
                    .HasName("PK__Rules__110458E2EFA7B088");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.Json)
                    .HasColumnName("json")
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.SqlPart)
                    .HasColumnName("sqlPart")
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.SqlStr)
                    .HasColumnName("sqlStr")
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.Template)
                    .HasColumnName("template")
                    .HasMaxLength(512)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Trades>(entity =>
            {
                entity.HasKey(e => e.TradeId)
                    .HasName("PK__Trades__3028BB5BADE6C685");

                entity.Property(e => e.Account)
                    .IsRequired()
                    .HasColumnName("account")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Benchmark)
                    .HasColumnName("benchmark")
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.Book)
                    .HasColumnName("book")
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.BuyPrice).HasColumnName("buyPrice");

                entity.Property(e => e.BuyQuantity).HasColumnName("buyQuantity");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreationName)
                    .HasColumnName("creationName")
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.DealName)
                    .HasColumnName("dealName")
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.DealType)
                    .HasColumnName("dealType")
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.RevisionDate)
                    .HasColumnName("revisionDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.RevisionName)
                    .HasColumnName("revisionName")
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.Security)
                    .HasColumnName("security")
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.SellPrice).HasColumnName("sellPrice");

                entity.Property(e => e.SellQuantity).HasColumnName("sellQuantity");

                entity.Property(e => e.Side)
                    .HasColumnName("side")
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.SourceListId)
                    .HasColumnName("sourceListId")
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TradeDate)
                    .HasColumnName("tradeDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Trader)
                    .HasColumnName("trader")
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Users__1788CC4C44DCF4F1");

                entity.Property(e => e.Fullname)
                    .HasColumnName("fullname")
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.Role)
                    .HasColumnName("role")
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(125)
                    .IsUnicode(false);
            });
        }
    }
}
