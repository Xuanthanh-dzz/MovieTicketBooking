using Microsoft.AspNetCore.Mvc;
using moviebooking.Application;
using moviebooking.Domain.Entities;

namespace moviebooking.API.Controllers;

[ApiController]
[Route("api/[Controller]")]
public class MovieController : ControllerBase
{
    private readonly IMovieService _movieservice;
    
    // Bơm cái vỏ bọc dịch vụ từ Application vào đây
    public MovieController (IMovieService movieService)
    {
        _movieservice = movieService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var movies = await _movieservice.GetAllMoviesAsync();
        return Ok(movies); //Trả về HTTP 200 kèm cục dữ liệu json
    }

    [HttpPost]

    public async Task<IActionResult> Create([FromBody] movie movie)
    {
        if (movie == null) return BadRequest("Dữ liệu phim không hợp lệ!");
        
        var createdMovie = await _movieservice.CreateMovieAsync(movie);
        return CreatedAtAction(nameof(GetAll), new {id = createdMovie.Id}, createdMovie);
    }
}