namespace AbstractFactory
{
    interface IProductB
    {
        string DoSomethingWithB();
        string DoSomethingWithCollaborator(IProductA productA);
    }
}
