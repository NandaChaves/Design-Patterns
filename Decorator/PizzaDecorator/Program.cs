using System;
namespace PizzaDecorator
{
     class Program
    {
        static void Main(string[] args)
        {
            //decorator design pattern
            IPizza pizza = new Pizza();
            IPizza cheeseDecorator = new CheeseDecorator(pizza);
            IPizza onionDecorator = new OnionDecorator(cheeseDecorator);
            IPizza baconDecorator = new BaconDecorator(onionDecorator);
            Console.WriteLine(baconDecorator.GetPizzaType());
            Console.ReadLine();
        }
    }
    //base interface
    interface IPizza
    {
        string GetPizzaType();
    }

    class Pizza : IPizza
    {
        public string GetPizzaType()
        {
            return "This is a basic Pizza";
        }
    }

    //base decorator
    class PizzaDecorator : IPizza
    {
        private IPizza _pizza;
        //constructor pizza decorator
        public PizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }
        public virtual string GetPizzaType()
        {
            return _pizza.GetPizzaType();
        }
    }

    //concrete decorators
    class CheeseDecorator: PizzaDecorator
    {
        public CheeseDecorator(IPizza pizza) : base(pizza) { }
        public override string GetPizzaType()
        {
            string type = base.GetPizzaType();
            type += "\r\n with Extra chesse";
            return type;
        }
    }

    class BaconDecorator : PizzaDecorator
    {
        public BaconDecorator(IPizza pizza) : base(pizza) { }
        public override string GetPizzaType()
        {
            string type = base.GetPizzaType();
            type += "\r\n with Extra bacon";
            return type;
        }
    }

    class OnionDecorator : PizzaDecorator
    {
        public OnionDecorator(IPizza pizza) : base(pizza) { }
        public override string GetPizzaType()
        {
            string type = base.GetPizzaType();
            type += "\r\n with Extra onion";
            return type;
        }
    }
}
