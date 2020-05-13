using System;
using System.Runtime.Serialization;

namespace HospitalSurvey.Utilities.Exceptions
{
    public class HospitalSurveyException : Exception
    {
        public HospitalSurveyException()
        {
        }

        public HospitalSurveyException(string message) : base(message)
        {
        }

        public HospitalSurveyException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected HospitalSurveyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }


}
