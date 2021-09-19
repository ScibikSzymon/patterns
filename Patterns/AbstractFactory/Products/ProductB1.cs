namespace AbstractFactory.Products
{
    class ProductB1 : IProductB
    {
        public string DoSomethingWithB()
        {
            return "Doing B1";
        }

        public string DoSomethingWithCollaborator(IProductA productA)
        {
            return $"Doing B1 with {productA.DoSomethingWithA()}";
        }
    }
}
