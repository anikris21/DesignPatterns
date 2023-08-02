namespace DecoratorPattern
{
    // derive the cake as cakeWithName instead;
    class CakeMessageDecorator: ICakeMessageDecorator
    {
        readonly ICake cake;
        public CakeMessageDecorator(ICake cake)
        {
            this.cake = cake;
        }

        public void AddMessage(string m)
        {
            cake.AddLayers($"Message for cake : {m}");
        }
    }
}
