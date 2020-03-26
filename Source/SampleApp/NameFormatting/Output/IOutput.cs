namespace SampleApp.NameFormatting.Output
{
    public interface IOutput<T>
    {
        void Write(T value);
    }
}