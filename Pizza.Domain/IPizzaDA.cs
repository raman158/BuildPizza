using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Pizza.DTO;

namespace Pizza.Domain
{
    public interface IPizzaDA 
    {
        Task<PizzaMenuModel> GetPizzaMenu();
        Task<PizzaBaseModel> SavePizza(PizzaModel PizzaDet);
    }
}
