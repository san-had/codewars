using System.Collections.Generic;

namespace SimplePipelineExample
{
    public class Pipeline
    {
        private List<IPipelineElement> pipeline = new List<IPipelineElement>();

        public void Add(IPipelineElement anElement)
        {
            pipeline.Add(anElement);

            if (pipeline.Count > 1)
            {
                pipeline[pipeline.Count - 2].Connect(pipeline[pipeline.Count - 1]);
            }
        }

        public void Run()
        {
            bool jobCompleted = false;

            while (!jobCompleted)
            {
                jobCompleted = true;
                for (int i = 0; i < pipeline.Count; i++)
                {
                    pipeline[i].Process();
                    jobCompleted = jobCompleted && pipeline[i].IsComplete;
                }
            }
        }
    }
}