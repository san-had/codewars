using System.Collections.Generic;

namespace PassportProcessing.Validators
{
    public abstract class BaseValidator : IValidator
    {
        public IValidator SetNext(IValidator next)
        {
            Next = next;
            return Next;
        }

        public virtual void Validate(Dictionary<string, string> passport)
        {
            Next?.Validate(passport);
        }

        private IValidator Next { get; set; }
    }
}