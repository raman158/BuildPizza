using System;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Pizza.DTO; 

namespace Pizza.Domain
{
    public class PizzaDA: IPizzaDA
    {

        public async Task<PizzaMenuModel> GetPizzaMenu()
        {
            PizzaMenuModel MenuJson = new PizzaMenuModel();
            try
            {
                string menu =await System.IO.File.ReadAllTextAsync(Directory.GetCurrentDirectory() + "\\Data\\PizzaMenu.txt");
                MenuJson = JsonConvert.DeserializeObject<PizzaMenuModel>(menu);
                return MenuJson;
            }
            catch (Exception ex)
            {
                MenuJson = null;
            }
            return MenuJson;
        }

        public async Task<PizzaBaseModel> SavePizza(PizzaModel PizzaDet)
        {
            PizzaBaseModel Resp = new PizzaBaseModel();
            try
            {
                Resp.id = (int)PizzaDet.OrderId;
                await File.WriteAllTextAsync(Directory.GetCurrentDirectory() + "\\Data\\PizzaOrder.txt", JsonConvert.SerializeObject(PizzaDet));
            }
            catch (Exception ex)
            {
                Resp = null;
            }
            
            return Resp;
        }

    }
}
