namespace DecoratorPattern
{
    // public 
    public interface ICake
    {
        void AddLayers(string l);

        public IEnumerator<string> PrintLayers();
    }
}
