using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace FlightFinder.Types.Exceptions
{
    [Serializable]
    public class TypeValidationException : BusinessLayerException
    {
        static string TypeValidationExceptionMessage = "Several errors have occured while validating";

        public TypeValidationException()
            : base(TypeValidationExceptionMessage)
        {
            Errors = new[] { TypeValidationExceptionMessage };
        }

        public TypeValidationException(IEnumerable<string> errors)
            : base(TypeValidationExceptionMessage, errors)
        {
        }

        public TypeValidationException(Exception inner, IEnumerable<string> errors)
            : base(TypeValidationExceptionMessage, inner, errors)
        {
        }

        protected TypeValidationException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
