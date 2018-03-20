﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace BeaverTail.API.DAL
{
    public interface IConfigurationRepository
    {
        Task<FooConfig> GetFoo(string Id);
        Task StoreFoo(FooConfig foo);
        Task<IList<FooConfig>> GetTopAsync();
    }
}