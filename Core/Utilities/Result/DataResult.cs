﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Result
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data, bool succes, string messages):base(succes,messages)
        {
            Data = data;
        }
        public DataResult(T data, bool succes) : base(succes)
        {
            Data = data;
        }
        public T Data { get; }
    }
}
