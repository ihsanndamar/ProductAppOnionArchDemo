﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Application.Exceptions
{
    public class ValidationException : Exception
    {
        public ValidationException() : base("Validation Error Occured")
        {
            
        }
        
        public ValidationException(String Message): base(Message)
        {
            
        }
        
        public ValidationException(Exception ex): base(ex.Message)
        {
            
        }
        
    }
}
