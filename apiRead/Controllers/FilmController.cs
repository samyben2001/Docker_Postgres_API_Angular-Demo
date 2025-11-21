using BStorm.Tools.Database;
using Microsoft.AspNetCore.Mvc;
using MovieAPI.Domain.Entities;
using System.Data.Common;

namespace MovieAPI.Controllers
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

        [HttpGet]
        public IActionResult GetFilms()
        {
            try
            {
                IEnumerable<Film> films = _dbConnection.ExecuteReader("SELECT id, titrefr, titreca, annee FROM film", reader => new Film
                (
                    (int)reader["id"],
                    (string)reader["titrefr"],
                    (string)reader["titreca"],
                    (int)reader["annee"]
                )).ToList();

                return Ok(films);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
