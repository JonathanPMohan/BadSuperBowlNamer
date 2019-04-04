using System;
using System.Collections.Generic;
using System.Text;

namespace BadSuperBowlNamer
{
    public class InvalidInputException : Exception
    {
        public InvalidInputException() : base("The User Input Received Was Invalid.")
        {

        }
    }
}
