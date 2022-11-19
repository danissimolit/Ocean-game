using System;

namespace OceanLibrary
{
    public class WrongAmountInput : Exception // власний клас винятку (власний exception)
                                              // на некоректне введення даних
    {
        public WrongAmountInput() : base()
        {

        }

        public WrongAmountInput(string message) : base(message)
        {

        }

        public WrongAmountInput(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
