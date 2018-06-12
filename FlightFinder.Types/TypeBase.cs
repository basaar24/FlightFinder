using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FlightFinder.Types
{
    using Exceptions;

    public class TypeBase
    {
        public void Validate()
        {
            var context = new ValidationContext(this, serviceProvider: null, items: null);
            var results = new List<ValidationResult>();
            var isValid = Validator.TryValidateObject(this, context, results, true);

            if (!isValid)
                throw new TypeValidationException();
        }
    }
}
