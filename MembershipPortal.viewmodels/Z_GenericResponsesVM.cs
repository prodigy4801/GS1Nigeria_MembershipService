﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.viewmodels
{
    public class Z_GenericResponsesVM<T> where T : class
    {
        public T Data { get; set; }
        public string Message { get; set; }
        public Boolean IsSuccess { get; set; }
    }
}
