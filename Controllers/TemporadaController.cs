using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using apiweb.Models;

namespace apiweb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TemporadaController : ControllerBase
    {
        private readonly List<Temporada> temporada = new List<Temporada>();

        public TemporadaController()
        {
            temporada.Add(new Temporada()
            {
                id = 1,
                nombre = "Temporada 1",
                anio = "2011",
                cantEpisodios = "10",
                libro = "A Game of Thrones",
                rating = 4.8f,
                foto = "https://cl.buscafs.com/www.tomatazos.com/public/uploads/images/55955/55955_173x256.jpg"
            });
            temporada.Add(new Temporada()
            {
                id = 2,
                nombre = "Temporada 2",
                anio = "2012",
                cantEpisodios = "10",
                libro = "A Clash of Kings",
                rating = 4.8f,
                foto = "https://cl.buscafs.com/www.tomatazos.com/public/uploads/images/57985/57985_173x256.jpg"
            });
            temporada.Add(new Temporada()

            {
                id = 3,
                nombre = "Temporada 3",
                anio = "2013",
                cantEpisodios = "10",
                libro = "A Storm of Swords",
                rating = 5.0f,
                foto = "https://cl.buscafs.com/www.tomatazos.com/public/uploads/images/57986/57986_173x256.jpg"
            });
            temporada.Add(new Temporada()
            {
                id = 4,
                nombre = "Temporada 4",
                anio = "2014",
                cantEpisodios = "10",
                libro = "A Storm of Swords",
                rating = 4.7f,
                foto = "https://cl.buscafs.com/www.tomatazos.com/public/uploads/images/57987/57987_173x256.jpg"
            });
            temporada.Add(new Temporada()
            {
                id = 5,
                nombre = "Temporada 5",
                anio = "2015",
                cantEpisodios = "10",
                libro = "A Feast for Crows, A Dance with Dragons and Original Content",
                rating = 4.2f,
                foto = "https://cl.buscafs.com/www.tomatazos.com/public/uploads/images/57989/57989_173x256.jpg"
            });
            temporada.Add(new Temporada()
            {
                id = 6,
                nombre = "Temporada 6",
                anio = "2016",
                cantEpisodios = "10",
                libro = "Outline fom The Winds of Winter and Original Content",
                rating = 4.6f,
                foto = "https://cl.buscafs.com/www.tomatazos.com/public/uploads/images/57990/57990_173x256.jpg"
            });
            temporada.Add(new Temporada()
            {
                id = 7,
                nombre = "Temporada 7",
                anio = "2017",
                cantEpisodios = "7",
                libro = "Outline from A Dream of Spring and Original Content",
                rating = 4.5f,
                foto = "https://cl.buscafs.com/www.tomatazos.com/public/uploads/images/150561/150561_173x257.jpg"
            });
            temporada.Add(new Temporada()
            {
                id = 8,
                nombre = "Temporada 8",
                anio = "2019",
                cantEpisodios = "6",
                libro = "Outline from A Dream of Spring and Original Content",
                rating = 2.7f,
                foto = "https://cl.buscafs.com/www.tomatazos.com/public/uploads/images/150560/150560_173x257.jpg"
            });
        }


        [HttpGet]
        public ActionResult<IEnumerable<Temporada>> Get()
        {
            return Ok(temporada);
        }

        [HttpGet("{id}")]
        public ActionResult<Temporada> GetSeasonById(int id)
        {

            var temp = temporada.Find(season => season.id == id);

            if (temp != null)
            {
                return Ok(temp);
            }
            else
            {
                return NotFound();
            }
        }
    }

}