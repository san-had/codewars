using System.Collections.Generic;

namespace PassportProcessing.Validators
{
    public interface IValidator
    {
        IValidator SetNext(IValidator next);

        void Validate(Dictionary<string, string> passport);
    }
}