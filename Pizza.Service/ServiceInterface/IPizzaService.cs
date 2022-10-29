using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Pizza.DTO;

namespace Pizza.Service.ServiceInterface
{
    public interface IPizzaService
    {
        Task<PizzaMenuModel> GetPizzaMenu();
        Task<PizzaBaseModel> SavePizza(PizzaModel PizzaDet);

    }
}
