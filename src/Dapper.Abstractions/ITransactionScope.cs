using System;

namespace Dapper.Abstractions
{
    public interface ITransactionScope : IDisposable
    {
        void Complete();
    }
}