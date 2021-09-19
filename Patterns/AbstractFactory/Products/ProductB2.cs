namespace AbstractFactory.Products
{
    class ProductB2 : IProductB
    {
        public string DoSomethingWithB()
        {
            return "Doing B2";
        }

        public string DoSomethingWithCollaborator(IProductA productA)
        {
            return $"Doing B2 with {productA.DoSomethingWithA()}";
        }
    }
}
