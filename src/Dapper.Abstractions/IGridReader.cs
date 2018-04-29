using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dapper.Abstractions
{
    public interface IGridReader : IDisposable
    {
        #region Sync Methods

        IEnumerable<dynamic> Read(bool buffered = true);

        dynamic ReadFirst();

        dynamic ReadFirstOrDefault();

        dynamic ReadSingle();

        dynamic ReadSingleOrDefault();

        IEnumerable<T> Read<T>(bool buffered = true);

        T ReadFirst<T>();

        T ReadFirstOrDefault<T>();

        T ReadSingle<T>();

        T ReadSingleOrDefault<T>();

        IEnumerable<object> Read(Type type, bool buffered = true);

        object ReadFirst(Type type);

        object ReadFirstOrDefault(Type type);

        object ReadSingle(Type type);

        object ReadSingleOrDefault(Type type);

        IEnumerable<TReturn> Read<TFirst, TSecond, TReturn>(Func<TFirst, TSecond, TReturn> func, string splitOn = "id", bool buffered = true);

        IEnumerable<TReturn> Read<TFirst, TSecond, TThird, TReturn>(Func<TFirst, TSecond, TThird, TReturn> func, string splitOn = "id", bool buffered = true);

        IEnumerable<TReturn> Read<TFirst, TSecond, TThird, TFourth, TReturn>(Func<TFirst, TSecond, TThird, TFourth, TReturn> func, string splitOn = "id", bool buffered = true);

        IEnumerable<TReturn> Read<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(Func<TFirst, TSecond, TThird, TFourth, TFifth, TReturn> func, string splitOn = "id", bool buffered = true);

        IEnumerable<TReturn> Read<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn> func, string splitOn = "id", bool buffered = true);

        IEnumerable<TReturn> Read<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn>(Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn> func, string splitOn = "id", bool buffered = true);

        IEnumerable<TReturn> Read<TReturn>(Type[] types, Func<object[], TReturn> map, string splitOn = "id", bool buffered = true);

        #endregion Sync Methods

        #region Async Methods

        Task<IEnumerable<dynamic>> ReadAsync(bool buffered = true);

        Task<dynamic> ReadFirstAsync();

        Task<dynamic> ReadFirstOrDefaultAsync();

        Task<dynamic> ReadSingleAsync();

        Task<dynamic> ReadSingleOrDefaultAsync();

        Task<IEnumerable<object>> ReadAsync(Type type, bool buffered = true);

        Task<object> ReadFirstAsync(Type type);

        Task<object> ReadFirstOrDefaultAsync(Type type);

        Task<object> ReadSingleAsync(Type type);

        Task<object> ReadSingleOrDefaultAsync(Type type);

        Task<IEnumerable<T>> ReadAsync<T>(bool buffered = true);

        Task<T> ReadFirstAsync<T>();

        Task<T> ReadFirstOrDefaultAsync<T>();

        Task<T> ReadSingleAsync<T>();

        Task<T> ReadSingleOrDefaultAsync<T>();

        #endregion Async Methods
    }
}