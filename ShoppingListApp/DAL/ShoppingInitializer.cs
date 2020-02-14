using ShoppingListApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingListApp.DAL
{
    public class ShoppingInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<ShoppingContext>
    {
        protected override void Seed(ShoppingContext context)
        {
            var shopping = new List<ShoppingList>
            {
                new ShoppingList{ID=1, Username="Tomas", Password="Tomas123", Items="Banana, Apple, Pear"},
                new ShoppingList{ID=2, Username="Viktor", Password="Viktor123", Items="Chocolate, Water, Ketchup"},
                new ShoppingList{ID=3, Username="Dexter", Password="Dexter123", Items="Burger, Fries, Orange"},

            };

            shopping.ForEach(s => context.ShoppingLists.Add(s));
            context.SaveChanges();
        }
    }
}