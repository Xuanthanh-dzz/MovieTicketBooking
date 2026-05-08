using Microsoft.EntityFrameworkCore;
using moviebooking.Application;
using moviebooking.Domain.Entities;

namespace moviebooking.Infrastructure;
public class MovieService : IMovieService
{
    private readonly ApplicationDbContext _context;
// Bơm Dbcontext vào để xài
    public MovieService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<movie>> GetAllMoviesAsync()
    {
        // Chọc xuống docker để lấy toàn bộ bảng lên ram 
        return await _context.movies.ToListAsync();
    }

    public async Task<movie> CreateMovieAsync(movie movie)
    {
        // Thêm 1 bộ phim vào bộ đệm EF Core
        await _context.movies.AddAsync(movie);

    // Bắn lệnh lưu xuống Docker SQL Server
    await _context.SaveChangesAsync();

    // Trả về chính bộ phim đó (lúc này đã có Id tự tăng)
    return movie;
    }
    
}