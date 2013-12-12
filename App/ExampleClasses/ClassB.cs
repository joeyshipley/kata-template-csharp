namespace Kata.App.ExampleClasses
{
    public interface IClassB
    {
        void StoreMessage(string message);
        string GetMessage();
    }

    public class ClassB : IClassB
    {
        private string _message;

        public void StoreMessage(string message)
        {
            _message = message;
        }

        public string GetMessage()
        {
            return _message;
        }
    }
}