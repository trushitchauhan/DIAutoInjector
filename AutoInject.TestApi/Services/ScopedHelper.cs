﻿using AutoInject.Attributes;

namespace AutoInject.TestApi.Services
{
    public interface IScopedHelper : IIdentity
    {
        void Method();
    }

    [Injectable(ServiceLifetime.Scoped)]
    public class ScopedHelper : IScopedHelper
    {
        public string InstanceId { get; } = Guid.NewGuid().ToString();
        public void Method()
        {
            Console.WriteLine(this.GetType().FullName);
        }
    }
}
