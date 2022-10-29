using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pizza.DTO;
using Pizza.Service.ServiceInterface;

namespace PizzaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizaaController : ControllerBase
    {
        private readonly IPizzaService PizzaService;

        public PizaaController(IPizzaService pizzaService)
        {
            this.PizzaService = pizzaService;
        }

        // GET api/GetPizzaMenu
        [HttpGet]
        [Route("GetPizzaMenu")]
        public async Task<PizzaMenuModel> GetPizzaMenu()
        {
            return await PizzaService.GetPizzaMenu();
        }

        // POST api/SavePizzaOrder
        [HttpPost]
        [Route("SavePizzaOrder")]
        public async Task<PizzaBaseModel> SavePizzaOrder([FromBody] PizzaModel PizzaDet)
        {
            return await PizzaService.SavePizza(PizzaDet);
        }

        
    }
}
