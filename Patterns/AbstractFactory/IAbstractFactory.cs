namespace AbstractFactory
{
    interface IAbstractFactory
    {
        IProductA CreateA();
        IProductB CreateB();
    }
}
