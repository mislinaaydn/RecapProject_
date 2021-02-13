using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErroeDataResult<T> : DataResult<T>
    {
        public ErroeDataResult(T data, string message) : base(data, false, message)
        {

        }
        public ErroeDataResult(T data) : base(data, false)
        {

        }
        public ErroeDataResult(string message) : base(default, false, message)
        {

        }
        public ErroeDataResult() : base(default, false)
        {

        }
    }
    
}

