namespace Kata.App.ExampleClasses
{
    public class ClassA
    {
        private readonly IClassB _classB;

        public ClassA(IClassB classB)
        {
            _classB = classB;
        }

        public void Store(string message)
        {
            _classB.StoreMessage(message);
        }

        public string Fetch()
        {
            return _classB.GetMessage();
        }
    }
}