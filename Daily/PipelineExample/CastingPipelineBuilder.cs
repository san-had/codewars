﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PipelineExample
{
    public class CastingPipelineBuilder : IPipeline
    {
        private List<Func<object, object>> _pipelineSteps = new List<Func<object, object>>();
        private BlockingCollection<object>[] _buffers;

        public event Action<object> Finished;

        public void AddStep(Func<object, object> stepFunc)
        {
            _pipelineSteps.Add(stepFunc);
        }

        public void Execute(object input)
        {
            var first = _buffers[0];
            first.Add(input);
        }

        public IPipeline GetPipeline()
        {
            _buffers = _pipelineSteps
                .Select(step => new BlockingCollection<object>())
                .ToArray();

            int bufferIndex = 0;
            foreach (var pipelineStep in _pipelineSteps)
            {
                var bufferIndexLocal = bufferIndex;
                Task.Run(() =>
                {
                    foreach (var input in _buffers[bufferIndexLocal].GetConsumingEnumerable())
                    {
                        var output = pipelineStep.Invoke(input);

                        bool isLastStep = bufferIndexLocal == _pipelineSteps.Count - 1;
                        if (isLastStep)
                        {
                            Finished?.Invoke(output);
                        }
                        else
                        {
                            var next = _buffers[bufferIndexLocal + 1];
                            next.Add(output);
                        }
                    }
                });
                bufferIndex++;
            }
            return this;
        }
    }
}