using System.Numerics;
using moviebooking.Domain.Entities;

namespace moviebooking.Application;
public interface IMovieService
{
    // Khai báo phương thức để lây danh sách tất cả phim
    Task<IEnumerable<movie>> GetAllMoviesAsync();
    
    Task<movie> CreateMovieAsync (movie movie);
    
}
