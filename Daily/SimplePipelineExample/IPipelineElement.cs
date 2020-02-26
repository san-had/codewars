using System.IO.Pipes;

namespace SimplePipelineExample
{
    public interface IPipelineElement
    {
        void SetInput(PipeStream inputStream);

        void Connect(IPipelineElement next);

        void Process();

        bool IsComplete
        {
            get;
        }
    }
}