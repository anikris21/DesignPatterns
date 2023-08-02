namespace DecoratorPattern
{
    public class StrawberryCake : ICake
    {
        List<string> layers = new List<string>();
        public void AddLayers(string l)
        {
            layers.Add(l);
        }

        public IEnumerator<string> PrintLayers()
        {
            return layers.GetEnumerator();
        }
    }
}
