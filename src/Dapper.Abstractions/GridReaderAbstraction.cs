using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dapper.Abstractions
{
    public class GridReaderAbstraction : IGridReader
    {
        private readonly SqlMapper.GridReader _gridReader;

        public GridReaderAbstraction(SqlMapper.GridReader gridReader)
        {
            _gridReader = gridReader;
        }

        #region Sync Methods

        public IEnumerable<dynamic> Read(bool buffered = true)
        {
            return _gridReader.Read(buffered);
        }

        public dynamic ReadFirst()
        {
            return _gridReader.ReadFirst();
        }

        public dynamic ReadFirstOrDefault()
        {
            return _gridReader.ReadFirstOrDefault();
        }

        public dynamic ReadSingle()
        {
            return _gridReader.ReadSingle();
        }

        public dynamic ReadSingleOrDefault()
        {
            return _gridReader.ReadSingleOrDefault();
        }

        public IEnumerable<T> Read<T>(bool buffered = true)
        {
            return _gridReader.Read<T>(buffered);
        }

        public T ReadFirst<T>()
        {
            return _gridReader.ReadFirst<T>();
        }

        public T ReadFirstOrDefault<T>()
        {
            return _gridReader.ReadFirstOrDefault<T>();
        }

        public T ReadSingle<T>()
        {
            return _gridReader.ReadSingle<T>();
        }

        public T ReadSingleOrDefault<T>()
        {
            return _gridReader.ReadSingleOrDefault<T>();
        }

        public IEnumerable<object> Read(Type type, bool buffered = true)
        {
            return _gridReader.Read(type, buffered);
        }

        public object ReadFirst(Type type)
        {
            return _gridReader.ReadFirst(type);
        }

        public object ReadFirstOrDefault(Type type)
        {
            return _gridReader.ReadFirstOrDefault(type);
        }

        public object ReadSingle(Type type)
        {
            return _gridReader.ReadSingle(type);
        }

        public object ReadSingleOrDefault(Type type)
        {
            return _gridReader.ReadSingleOrDefault(type);
        }

        public IEnumerable<TReturn> Read<TFirst, TSecond, TReturn>(Func<TFirst, TSecond, TReturn> func, string splitOn = "id", bool buffered = true)
        {
            return _gridReader.Read(func, splitOn, buffered);
        }

        public IEnumerable<TReturn> Read<TFirst, TSecond, TThird, TReturn>(Func<TFirst, TSecond, TThird, TReturn> func, string splitOn = "id", bool buffered = true)
        {
            return _gridReader.Read(func, splitOn, buffered);
        }

        public IEnumerable<TReturn> Read<TFirst, TSecond, TThird, TFourth, TReturn>(Func<TFirst, TSecond, TThird, TFourth, TReturn> func, string splitOn = "id", bool buffered = true)
        {
            return _gridReader.Read(func, splitOn, buffered);
        }

        public IEnumerable<TReturn> Read<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(Func<TFirst, TSecond, TThird, TFourth, TFifth, TReturn> func, string splitOn = "id", bool buffered = true)
        {
            return _gridReader.Read(func, splitOn, buffered);
        }

        public IEnumerable<TReturn> Read<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn> func, string splitOn = "id", bool buffered = true)
        {
            return _gridReader.Read(func, splitOn, buffered);
        }

        public IEnumerable<TReturn> Read<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn>(Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn> func, string splitOn = "id", bool buffered = true)
        {
            return _gridReader.Read(func, splitOn, buffered);
        }

        public IEnumerable<TReturn> Read<TReturn>(Type[] types, Func<object[], TReturn> map, string splitOn = "id", bool buffered = true)
        {
            return _gridReader.Read(types, map, splitOn, buffered);
        }

        #endregion Sync Methods

        #region Async Methods

        public Task<IEnumerable<dynamic>> ReadAsync(bool buffered = true)
        {
            return _gridReader.ReadAsync(buffered);
        }

        public Task<dynamic> ReadFirstAsync()
        {
            return _gridReader.ReadFirstAsync();
        }

        public Task<dynamic> ReadFirstOrDefaultAsync()
        {
            return _gridReader.ReadFirstOrDefaultAsync();
        }

        public Task<dynamic> ReadSingleAsync()
        {
            return _gridReader.ReadSingleAsync();
        }

        public Task<dynamic> ReadSingleOrDefaultAsync()
        {
            return _gridReader.ReadSingleOrDefaultAsync();
        }

        public Task<IEnumerable<object>> ReadAsync(Type type, bool buffered = true)
        {
            return _gridReader.ReadAsync(type, buffered);
        }

        public Task<object> ReadFirstAsync(Type type)
        {
            return _gridReader.ReadFirstAsync(type);
        }

        public Task<object> ReadFirstOrDefaultAsync(Type type)
        {
            return _gridReader.ReadFirstOrDefaultAsync(type);
        }

        public Task<object> ReadSingleAsync(Type type)
        {
            return _gridReader.ReadSingleAsync(type);
        }

        public Task<object> ReadSingleOrDefaultAsync(Type type)
        {
            return _gridReader.ReadSingleOrDefaultAsync(type);
        }

        public Task<IEnumerable<T>> ReadAsync<T>(bool buffered = true)
        {
            return _gridReader.ReadAsync<T>(buffered);
        }

        public Task<T> ReadFirstAsync<T>()
        {
            return _gridReader.ReadFirstAsync<T>();
        }

        public Task<T> ReadFirstOrDefaultAsync<T>()
        {
            return _gridReader.ReadFirstOrDefaultAsync<T>();
        }

        public Task<T> ReadSingleAsync<T>()
        {
            return _gridReader.ReadSingleAsync<T>();
        }

        public Task<T> ReadSingleOrDefaultAsync<T>()
        {
            return _gridReader.ReadSingleOrDefaultAsync<T>();
        }

        #endregion Async Methods

        public void Dispose()
        {
            _gridReader.Dispose();
        }
    }
}