﻿using FNS.Domain.Models;

namespace FNS.Services.Abstractions
{
    public interface IServiceBase<T>
        where T : class, IEntityBase, new()
    {
        
    }
}
