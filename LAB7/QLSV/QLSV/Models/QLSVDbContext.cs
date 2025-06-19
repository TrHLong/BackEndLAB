using Microsoft.EntityFrameworkCore;

namespace QLSV.Models
{
    public partial class QLSVDbContext : DbContext
    {
        public QLSVDbContext()
        {
        }

        public QLSVDbContext(DbContextOptions<QLSVDbContext> options)
            : base(options)
        {
        }

        // DbSet cho Class và Student
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Cấu hình kết nối đến cơ sở dữ liệu SQL Server
            optionsBuilder.UseSqlServer("Server=DESKTOP-164BNQG\\LONG153;Database=QLSV;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Cấu hình bảng Class
            modelBuilder.Entity<Class>(entity =>
            {
                entity.HasKey(e => e.ClassId).HasName("PK__Class__7577347E15DF7D12");

                entity.ToTable("Class");

                entity.Property(e => e.ClassId).HasColumnName("classId");
                entity.Property(e => e.ClassName)
                    .HasMaxLength(255)
                    .HasColumnName("className");

                // Cấu hình quan hệ giữa Class và Student
                entity.HasMany(e => e.Students)
                    .WithOne(s => s.Class)
                    .HasForeignKey(s => s.classId)
                    .HasConstraintName("fk_student_class");
            });

            // Cấu hình bảng Student
            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Student");

                // Cấu hình Primary Key cho Student
                entity.HasKey(e => e.studentId).HasName("pk_studentId");

                // Cấu hình các thuộc tính trong bảng Student
                entity.Property(e => e.studentId)
                    .UseIdentityColumn(); // Tự tăng cho studentId

                entity.Property(e => e.studentName)
                    .HasMaxLength(255)
                    .HasColumnName("studentName");

                entity.Property(e => e.phone)
                    .HasMaxLength(255)
                    .HasColumnName("phone");

                entity.Property(e => e.email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                // Cấu hình mối quan hệ giữa Student và Class
                entity.HasOne(s => s.Class)
                    .WithMany(c => c.Students)
                    .HasForeignKey(s => s.classId)
                    .HasConstraintName("fk_student_class");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
