using Microsoft.EntityFrameworkCore;
using moviebooking.Domain.Entities; // Nhúng tầng domain vào để hệ thống hiểu class movie

namespace moviebooking.Infrastructure;
public class ApplicationDbContext : DbContext
{
 // Hàm khởi tạo nhận vào các tuỳ chọn cấu hình của DbContext từ bên ngoài (thường là từ Startup.cs hoặc Program.cs) đổ vào
 public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options): base(options)
 {
 }
 // Đăng ký bảng movies vào hệ thống
 public DbSet<movie> movies { get; set; } = null!;
    
}
