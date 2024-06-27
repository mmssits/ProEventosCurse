using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {

         private readonly DataContext _dbContext;

        public EventosController(DataContext dbContext)
        {
            _dbContext = dbContext;
        }


        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _dbContext.Eventos;         
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return _dbContext.Eventos.FirstOrDefault(evento => evento.EventoId == id);   
        }

    
    }
}
