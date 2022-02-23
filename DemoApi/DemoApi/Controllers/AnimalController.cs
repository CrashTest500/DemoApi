using DemoApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DemoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        private readonly DogStore dogStore;

        public AnimalController(DogStore dogStore)
        {
            this.dogStore = dogStore;
        }

        [HttpGet("{id}")]
        public Dog Get(int id) => dogStore.Get(id);

        [HttpGet]
        public List<Dog> GetAll() => dogStore.Get();
    }
}
