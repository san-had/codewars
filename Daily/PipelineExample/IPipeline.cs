using System;

namespace PipelineExample
{
    public interface IPipeline
    {
        void Execute(object input);

        event Action<object> Finished;
    }
}