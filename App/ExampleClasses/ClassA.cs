namespace Kata.App.ExampleClasses
{
    public class ClassA
    {
        private readonly IClassB _classB;
        private readonly AbilityToSpeak _animalVoice;

        public ClassA(IClassB classB, AbilityToSpeak animalVoice)
        {
            _classB = classB;
            _animalVoice = animalVoice;
        }

        public void Store(string message)
        {
            _classB.StoreMessage(message);
        }

        public string Fetch()
        {
            return _classB.GetMessage();
        }

        public string Speak()
        {
            return _animalVoice.Speak();
        }
    }
}