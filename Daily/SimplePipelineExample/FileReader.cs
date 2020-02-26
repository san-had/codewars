using System;
using System.IO.Pipes;

namespace SimplePipelineExample
{
    public class FileReader : IPipelineElement
    {
        public bool IsComplete => throw new NotImplementedException();

        public void Connect(IPipelineElement next)
        {
            throw new NotImplementedException();
        }

        public void Process()
        {
            throw new NotImplementedException();
        }

        public void SetInput(PipeStream inputStream)
        {
            throw new NotImplementedException();
        }
    }
}