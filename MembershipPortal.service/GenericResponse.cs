﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.service
{
    public class GenericResponse<T> where T : class
    {
        public T Data { get; set; }
        public string Message { get; set; }
        public Boolean IsSuccess { get; set; }
    }
}