using AbstractFactory.Products;

namespace AbstractFactory
{
    class AbstractFactory1 : IAbstractFactory
    {
        public IProductA CreateA()
        {
            return new ProductA1();
        }

        public IProductB CreateB()
        {
            return new ProductB1();
        }
    }
    class AbstractFactory2 : IAbstractFactory
    {
        public IProductA CreateA()
        {
            return new ProductA2();
        }

        public IProductB CreateB()
        {
            return new ProductB2();
        }
    }
}
