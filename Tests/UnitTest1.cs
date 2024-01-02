using ClassLib;
using ClassLib.Burgers;
using ClassLib.Commands;
using ClassLib.ConcreteDrinks;
using ClassLib.Drinks.Decorators;
using ClassLib.Facade;
using ClassLib.Food.Pizza;
using ClassLib.Food.Sandwiches;

namespace Tests
{
    [TestClass]
    public class TestDrinks
    {
        [TestMethod]
        public void TestCoffee()
        {
            AbstractDrinks coffee = new Cream(new Sugar(new Coffee(), SugarSpoons.One_Spoon));
            AbstractDrinks coffee2 = new Cream(new Sugar(new Coffee(), SugarSpoons.Two_Spoons));
            
            Assert.AreNotEqual(coffee2.GetPrice(), coffee.GetPrice());
        }

        [TestMethod]
        public void TestTea()
        {
            AbstractDrinks tea = new Tea();
            AbstractDrinks teaWithSugar = new Sugar(new Tea(), SugarSpoons.Half_Spoon);

            Assert.AreNotEqual(tea.GetCalories(), teaWithSugar.GetCalories());
            Assert.AreNotEqual(tea.GetPrice(),teaWithSugar.GetPrice());
        }

        [TestMethod]
        public void TestCola_Fanta()
        {
            AbstractDrinks cola = new Cola(Size.Small);
            AbstractDrinks fanta = new Fanta(Size.Small);

            Assert.AreNotEqual(fanta.GetPrice(), cola.GetPrice());
            Assert.AreNotEqual(cola.GetDescription(), fanta.GetDescription());
            Assert.AreEqual(fanta.GetCalories(),cola.GetCalories());
        }
    }

    [TestClass]
    public class TestFood
    {
        [TestMethod]
        public void TestPizza()
        {
            PizzaAbstractFabric Smallpizza = new SalamiPizza(Size.Small);
            PizzaAbstractFabric Largepizza = new BaconPizza(Size.Large);
            PizzaAbstractFabric SmallpizzaBacon = new BaconPizza(Size.Small);

            Assert.AreNotEqual(Smallpizza.GetPrice(), SmallpizzaBacon.GetPrice());
            Assert.AreEqual(Largepizza.GetName(), SmallpizzaBacon.GetName());
            Assert.AreNotEqual(SmallpizzaBacon.GetCalories(),Largepizza.GetCalories());
        }

        [TestMethod]
        public void TestBurgers()
        {
            BurgerAbstractFabric vege = new VegeBurger();
            BurgerAbstractFabric bacon = new BaconBurger();

            Assert.AreNotEqual(vege.GetCalories(), bacon.GetCalories());
            
        }
    }

    [TestClass]
    public class TestOrder
    {
        [TestMethod]
        public void MakeOrder()
        {
            BurgerAbstractFabric vege = new VegeBurger();
            AbstractDrinks fanta = new Fanta(Size.Small);
            double cost = vege.GetPrice() + fanta.GetPrice();

            Waitress waitress = new Waitress(vege,fanta);
            CreatingOrder order = new CreatingOrder();
            order.CreateOrder(waitress);
            Assert.AreEqual(waitress.OrderCost, cost);
        }
    }
}