using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace FlightFinder.Types.Exceptions
{
    [Serializable]
    public class DuplicateItemException : BusinessLayerException
    {
        const string DuplicateItemExceptionMessage = "Duplication is not allowed";

        public DuplicateItemException()
            : base(DuplicateItemExceptionMessage) { }

        public DuplicateItemException(Exception inner, IEnumerable<string> errors)
            : base(DuplicateItemExceptionMessage, inner, errors) { }

        protected DuplicateItemException(SerializationInfo info, StreamingContext context)
            : base(info, context) { }
    }
}
