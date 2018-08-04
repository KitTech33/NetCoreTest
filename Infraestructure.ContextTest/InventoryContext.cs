using Domain.Entities.Inventory;
using Infraestructure.Context.Inventory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Infraestructure.ContextTest
{
    [TestClass]
    public class InventoryContext
    {
        //Cuando se inicia esta clase de pruebas, se bloquea la BD, y luego hago la prueba del test.
        [AssemblyInitialize]
        public static void EnviromentSetup(TestContext testContext)
        {
            using (InventoryDB db = new InventoryDB())
            {
                //Elimina la BD en SQL Server.
                db.Database.EnsureDeleted();
            }
        }

        //Prueba unitaria
        [TestMethod]
        public void DatabaseCreation()
        {
            using (InventoryDB db = new InventoryDB())
            {
                //Crea la BD en SQL Server.
                db.Database.EnsureCreated();
            }
        }

        //Prueba unitaria
        [TestMethod]
        public void InsertCategory()
        {
            //Inserta un dato en la tabla de la BD que hemos creado.
            using (InventoryDB db = new InventoryDB())
            {
                db.Categories.Add(new Category()
                {
                    Name = "Electrodomesticos",
                    Description = "Equipos Electricos para el uso domestico"
                });

                //SaveChange devuelve un numero q es el numero de cambios q hace en la BD.
                int numberOfChanges = db.SaveChanges();
                Assert.AreEqual(numberOfChanges, 1);
            }
        }
    }
}

