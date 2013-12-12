namespace Kata.App.ExampleClasses
{
    public interface AbilityToSpeak
    {
        string Speak();
    }

    public class ClassC : AbilityToSpeak
    {
        public string Speak()
        {
            return "barky-bark!";
        }
    }
}