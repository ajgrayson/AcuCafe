using System;

namespace AcuCafe.Exceptions
{
    public class InvalidIngredientException : Exception
    {
        public InvalidIngredientException(string message) : base(message)
        {
        }
    }
}
