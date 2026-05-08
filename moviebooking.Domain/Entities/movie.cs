namespace moviebooking.Domain.Entities;
public class movie
{
    // ID tự động tăng để làm khoá chính (primary key) trong cơ sở dữ liệu
    public int Id { get; set; } 
    // Tiêu đề của bộ phim
    public string Title { get; set; } = string.Empty;
    // Mô tả nội dung phim
    public string Description { get; set; } = string.Empty;
    // Thời lượng phim tính bằng phút
    public int drurationInMinutes { get; set; }
    // Ngày khởi chiếu (release date) 
    public DateTime ReleaseDate { get; set; }

    // Trailler phim
    public string Traillerurl {get; set; } = string.Empty;
}
