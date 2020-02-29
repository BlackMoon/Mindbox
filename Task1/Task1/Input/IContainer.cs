namespace Task1.Inputs
{
    using System.Collections.Generic;

    public interface IContainer
    {
        string [] Arguments { get; }

        string Title { get;}

        void Prepare();

        void Execute();
    }

    public interface IContainer<T> : IContainer
    {
        IDictionary<string, T> ArgumentValues { get; }
    }
}
