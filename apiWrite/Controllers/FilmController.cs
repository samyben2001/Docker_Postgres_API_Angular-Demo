using BStorm.Tools.Database;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApiWrite.Domain.Entities;
using System.Data.Common;

namespace MovieApiWrite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        private readonly DbConnection _dbConnection;

        public FilmController(DbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        [HttpPost]
        public IActionResult CreateFilm([FromBody] Film film)
        {
            try
            {
                _dbConnection.ExecuteNonQuery(
                    "INSERT INTO Film (titrefr, titreca, annee) VALUES (@TitreFR, @TitreCA, @Annee)", false,
                    new
                    {
                        titrefr = film.TitreFR,
                        titreca = film.TitreCA,
                        annee = film.Annee
                    });

                return NoContent();
            }
            catch (Exception ex)
            {

                return BadRequest(new { ex.Message });
            }
        }
    }
}
