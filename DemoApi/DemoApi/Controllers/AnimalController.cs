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

        [HttpGet("Get")]
        public Dog Get(int i) => dogStore.Get(i);

        [HttpGet("GetAll")]
        public List<Dog> GetAll() => dogStore.Get();
    }
}
