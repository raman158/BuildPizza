using System;
using System.Collections.Generic;

namespace Pizza.DTO
{
    public class PizzaModel
    {
        public int Crust { get; set; }
        public int Sausage { get; set; }
        public int AddOnCheeze { get; set; }
        public List<PizzaBaseModel> Toppings { get; set; }
        public int? OrderId { get; set; }
    }

    public class PizzaMenuModel
    {
        public List<PizzaBaseModel> crust { get; set; }
        public List<PizzaBaseModel> sausage { get; set; }
        public List<PizzaBaseModel> addOnCheeze { get; set; }
        public List<PizzaBaseModel> toppings { get; set; }
    }

    public class PizzaBaseModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public string currency { get; set; }
        public bool isSelected { get; set; }
    }
}
