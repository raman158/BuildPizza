using System;
using System.Threading.Tasks;
using Pizza.Domain;
using Pizza.DTO;
using Pizza.Service.ServiceInterface;

namespace Pizza.Service
{
    public class PizzaService : IPizzaService
    {
        private readonly IPizzaDA PizzaDal;
        public PizzaService(IPizzaDA pizzaDal)
        {
            this.PizzaDal = pizzaDal;
        }
        public async Task<PizzaMenuModel> GetPizzaMenu()
        {
            return await PizzaDal.GetPizzaMenu();
        }

        public async Task<PizzaBaseModel> SavePizza(PizzaModel PizzaDet)
        {
            PizzaDet.OrderId = new Random().Next(100, 100000);
            return await PizzaDal.SavePizza(PizzaDet);
        }
    }
}
