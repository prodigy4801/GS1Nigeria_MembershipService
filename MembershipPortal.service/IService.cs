﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.service
{
    public interface IService<T> where T : class
    {
        Task<GenericResponseList<T>> GetAll();
        Task<GenericResponse<T>> GetByID(int id);
        Task<GenericResponse<T>> Save(T obj);
        Task<GenericResponse<T>> Remove(T obj);
        Task<GenericResponse<T>> Remove(int id);
    }
}
