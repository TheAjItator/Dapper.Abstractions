using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace DapperWrapper.Interfaces
{
    public interface IDbExecutor : IDisposable
    {
        int Execute(
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = default(int?),
            CommandType? commandType = default(CommandType?));

        IEnumerable<dynamic> Query(
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            bool buffered = true,
            int? commandTimeout = default(int?),
            CommandType? commandType = default(CommandType?));

        IEnumerable<TReturn> Query<TFirst, TSecond, TReturn>(
            string sql,
            Func<TFirst, TSecond, TReturn> map,
            object param = null,
            IDbTransaction transaction = null,
            bool buffered = true,
            string splitOn = "Id",
            int? commandTimeout = default(int?),
            CommandType? commandType = default(CommandType?));

        dynamic QueryFirst(
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null);

        dynamic QueryFirstOrDefault(
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null);

        dynamic QuerySingle(
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null);

        dynamic QuerySingleOrDefault(
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null);

        object QueryFirst(
            Type type,
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null);

        object QueryFirstOrDefault(
            Type type,
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null);

        object QuerySingle(
            Type type,
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null);

        object QuerySingleOrDefault(
            Type type,
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null);

        T QueryFirst<T>(
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null);

        T QueryFirstOrDefault<T>(
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null);

        T QuerySingle<T>(
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null);

        T QuerySingleOrDefault<T>(
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null);

        IEnumerable<T> Query<T>(
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            bool buffered = true,
            int? commandTimeout = default(int?),
            CommandType? commandType = default(CommandType?));

        IGridReader QueryMultiple(
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = default(int?),
            CommandType? commandType = default(CommandType?));

        #region Additional Extensions

        IEnumerable<T> QueryAndTrimResults<T>(
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            bool buffered = true,
            int? commandTimeout = default(int?),
            CommandType? commandType = default(CommandType?));

        IEnumerable<TReturn> QueryAndTrimResults<TFirst, TSecond, TReturn>(
            string sql,
            Func<TFirst, TSecond, TReturn> map,
            object param = null,
            IDbTransaction transaction = null,
            bool buffered = true,
            string splitOn = "Id",
            int? commandTimeout = default(int?),
            CommandType? commandType = default(CommandType?));

        #endregion Additional Extensions

        #region Async

        Task<int> ExecuteAsync(
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = default(int?),
            CommandType? commandType = default(CommandType?));

        Task<IEnumerable<dynamic>> QueryAsync(
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = default(int?),
            CommandType? commandType = default(CommandType?));

        Task<IEnumerable<T>> QueryAsync<T>(
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = default(int?),
            CommandType? commandType = default(CommandType?));

        Task<IGridReader> QueryMultipleAsync(
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = default(int?),
            CommandType? commandType = default(CommandType?));

        Task<IEnumerable<dynamic>> QueryAsync(CommandDefinition command);

        Task<dynamic> QueryFirstAsync(CommandDefinition command);

        Task<dynamic> QueryFirstOrDefaultAsync(CommandDefinition command);

        Task<dynamic> QuerySingleAsync(CommandDefinition command);

        Task<dynamic> QuerySingleOrDefaultAsync(CommandDefinition command);

        Task<T> QueryFirstAsync<T>(
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null);

        Task<T> QueryFirstOrDefaultAsync<T>(
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null);

        Task<T> QuerySingleAsync<T>(
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null);

        Task<T> QuerySingleOrDefaultAsync<T>(
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null);

        Task<IEnumerable<object>> QueryAsync(
            Type type,
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null);

        Task<object> QueryFirstAsync(
            Type type,
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null);

        Task<object> QueryFirstOrDefaultAsync(
            Type type,
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null);

        Task<object> QuerySingleAsync(
            Type type,
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null);

        Task<object> QuerySingleOrDefaultAsync(
            Type type,
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null);

        Task<IEnumerable<object>> QueryAsync(Type type, CommandDefinition command);

        Task<object> QueryFirstAsync(Type type, CommandDefinition command);

        Task<object> QueryFirstOrDefaultAsync(Type type, CommandDefinition command);

        Task<object> QuerySingleAsync(Type type, CommandDefinition command);

        Task<object> QuerySingleOrDefaultAsync(Type type, CommandDefinition command);

        #endregion Async
    }
}