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
                IEnumerable<Film> films = _dbConnection.ExecuteReader("SELECT id, titre_fr, titre_ca, annee FROM film", reader => new Film
                (
                    (int)reader["id"],
                    (string)reader["titre_fr"],
                    (string)reader["titre_ca"],
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
