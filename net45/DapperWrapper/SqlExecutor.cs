using Dapper;
using DapperWrapper.Extensions;
using DapperWrapper.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DapperWrapper
{
    /// <summary>
    /// Class to create a Sql Executor
    /// </summary>
    public class SqlExecutor : IDbExecutor
    {
        #region Members

        /// <summary>
        /// The SQL connection object
        /// </summary>
        private readonly SqlConnection _sqlConnection;

        #endregion Members

        /// <summary>
        /// Constructor for the SQL Executor
        /// </summary>
        /// <param name="sqlConnection"></param>
        public SqlExecutor(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }

        #region Sync Methods

        public int Execute(
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = default(int?),
            CommandType? commandType = default(CommandType?))
        {
            return _sqlConnection.Execute(
                sql,
                param,
                transaction,
                commandTimeout,
                commandType);
        }

        public IEnumerable<dynamic> Query(
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            bool buffered = true,
            int? commandTimeout = default(int?),
            CommandType? commandType = default(CommandType?))
        {
            return _sqlConnection.Query(
                sql,
                param,
                transaction,
                buffered,
                commandTimeout,
                commandType);
        }

        public IEnumerable<TReturn> Query<TFirst, TSecond, TReturn>(
            string sql,
            Func<TFirst, TSecond, TReturn> map,
            object param = null,
            IDbTransaction transaction = null,
            bool buffered = true,
            string splitOn = "Id",
            int? commandTimeout = default(int?),
            CommandType? commandType = default(CommandType?))
        {
            return SqlMapper.Query<TFirst, TSecond, TReturn>(_sqlConnection, sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public dynamic QueryFirst(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null,
          CommandType? commandType = null)
        {
            return SqlMapper.QueryFirst(_sqlConnection, sql, param, transaction, commandTimeout, commandType);
        }

        public dynamic QueryFirstOrDefault(string sql, object param = null, IDbTransaction transaction = null,
            int? commandTimeout = null, CommandType? commandType = null)
        {
            return SqlMapper.QueryFirstOrDefault(_sqlConnection, sql, param, transaction, commandTimeout, commandType);
        }

        public dynamic QuerySingle(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return SqlMapper.QuerySingle(_sqlConnection, sql, param, transaction, commandTimeout, commandType);
        }

        public dynamic QuerySingleOrDefault(string sql, object param = null, IDbTransaction transaction = null,
            int? commandTimeout = null, CommandType? commandType = null)
        {
            return SqlMapper.QuerySingleOrDefault(_sqlConnection, sql, param, transaction, commandTimeout, commandType);
        }

        public object QueryFirst(Type type, string sql, object param = null, IDbTransaction transaction = null,
            int? commandTimeout = null, CommandType? commandType = null)
        {
            return SqlMapper.QueryFirst(_sqlConnection, type, sql, param, transaction, commandTimeout, commandType);
        }

        public object QueryFirstOrDefault(Type type, string sql, object param = null, IDbTransaction transaction = null,
            int? commandTimeout = null, CommandType? commandType = null)
        {
            return SqlMapper.QueryFirstOrDefault(_sqlConnection, type, sql, param, transaction, commandTimeout,
                commandType);
        }

        public object QuerySingle(Type type, string sql, object param = null, IDbTransaction transaction = null,
            int? commandTimeout = null, CommandType? commandType = null)
        {
            return SqlMapper.QuerySingle(_sqlConnection, type, sql, param, transaction, commandTimeout, commandType);
        }

        public object QuerySingleOrDefault(Type type, string sql, object param = null, IDbTransaction transaction = null,
            int? commandTimeout = null, CommandType? commandType = null)
        {
            return SqlMapper.QuerySingleOrDefault(_sqlConnection, type, sql, param, transaction, commandTimeout,
                commandType);
        }

        public T QueryFirst<T>(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return SqlMapper.QueryFirst<T>(_sqlConnection, sql, param, transaction, commandTimeout, commandType);
        }

        public T QueryFirstOrDefault<T>(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return SqlMapper.QueryFirstOrDefault<T>(_sqlConnection, sql, param, transaction, commandTimeout, commandType);
        }

        public T QuerySingle<T>(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return SqlMapper.QuerySingle<T>(_sqlConnection, sql, param, transaction, commandTimeout, commandType);
        }

        public T QuerySingleOrDefault<T>(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return SqlMapper.QuerySingleOrDefault<T>(_sqlConnection, sql, param, transaction, commandTimeout,
                commandType);
        }
        public IEnumerable<T> Query<T>(
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            bool buffered = true,
            int? commandTimeout = default(int?),
            CommandType? commandType = default(CommandType?))
        {
            return SqlMapper.Query<T>(_sqlConnection, sql,
                param,
                transaction,
                buffered,
                commandTimeout,
                commandType);
        }

        public IGridReader QueryMultiple(
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = default(int?),
            CommandType? commandType = default(CommandType?))
        {
            var reader = _sqlConnection.QueryMultiple(sql, param, transaction, commandTimeout, commandType);
            return new GridReaderWrapper(reader);
        }

        #endregion Sync Methods

        #region Additional Extensions

        /// <summary>
        /// Perform the Query and then trim any strings that are returned
        /// NOTE: There could be a performance hit when doing this
        /// </summary>
        public IEnumerable<T> QueryAndTrimResults<T>(
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            bool buffered = true,
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return AdditionalDapper.Query<T>(_sqlConnection, sql, param, transaction, buffered, commandTimeout, commandType);
        }

        /// <summary>
        /// Perform the Query and then trim any strings that are returned
        /// NOTE: There could be a performance hit when doing this
        /// </summary>
        public IEnumerable<TReturn> QueryAndTrimResults<TFirst, TSecond, TReturn>(
            string sql,
            Func<TFirst, TSecond, TReturn> map,
            object param = null,
            IDbTransaction transaction = null,
            bool buffered = true,
            string splitOn = "Id",
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return AdditionalDapper.Query<TFirst, TSecond, TReturn>(_sqlConnection, sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        #endregion Additional Extensions

        #region Async Methods

        public Task<int> ExecuteAsync(
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = default(int?),
            CommandType? commandType = default(CommandType?))
        {
            return _sqlConnection.ExecuteAsync(sql, param, transaction, commandTimeout, commandType);
        }

        public Task<IEnumerable<dynamic>> QueryAsync(
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = default(int?),
            CommandType? commandType = default(CommandType?))
        {
            return _sqlConnection.QueryAsync(sql, param, transaction, commandTimeout, commandType);
        }

        public Task<IEnumerable<T>> QueryAsync<T>(
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = default(int?),
            CommandType? commandType = default(CommandType?))
        {
            return _sqlConnection.QueryAsync<T>(sql, param, transaction, commandTimeout, commandType);
        }

        public async Task<IGridReader> QueryMultipleAsync(
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = default(int?),
            CommandType? commandType = default(CommandType?))
        {
            var reader = await _sqlConnection.QueryMultipleAsync(sql, param, transaction, commandTimeout, commandType).ConfigureAwait(false);
            return new GridReaderWrapper(reader);
        }

        public Task<IEnumerable<dynamic>> QueryAsync(CommandDefinition command)
        {
            return _sqlConnection.QueryAsync(command);
        }

        public Task<dynamic> QueryFirstAsync(CommandDefinition command)
        {
            return _sqlConnection.QueryFirstAsync(command);
        }

        public Task<dynamic> QueryFirstOrDefaultAsync(CommandDefinition command)
        {
            return _sqlConnection.QueryFirstOrDefaultAsync(command);
        }

        public Task<dynamic> QuerySingleAsync(CommandDefinition command)
        {
            return _sqlConnection.QuerySingleAsync(command);
        }

        public Task<dynamic> QuerySingleOrDefaultAsync(CommandDefinition command)
        {
            return _sqlConnection.QuerySingleOrDefaultAsync(command);
        }

        public Task<T> QueryFirstAsync<T>(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return _sqlConnection.QueryFirstAsync<T>(sql, param, transaction, commandTimeout, commandType);
        }

        public Task<T> QueryFirstOrDefaultAsync<T>(string sql, object param = null, IDbTransaction transaction = null,
            int? commandTimeout = null, CommandType? commandType = null)
        {
            return _sqlConnection.QueryFirstOrDefaultAsync<T>(sql, param, transaction, commandTimeout, commandType);
        }

        public Task<T> QuerySingleAsync<T>(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return _sqlConnection.QuerySingleAsync<T>(sql, param, transaction, commandTimeout, commandType);
        }

        public Task<T> QuerySingleOrDefaultAsync<T>(string sql, object param = null, IDbTransaction transaction = null,
            int? commandTimeout = null, CommandType? commandType = null)
        {
            return _sqlConnection.QuerySingleOrDefaultAsync<T>(sql, param, transaction, commandTimeout, commandType);
        }

        public Task<IEnumerable<object>> QueryAsync(Type type, string sql, object param = null, IDbTransaction transaction = null,
            int? commandTimeout = null, CommandType? commandType = null)
        {
            return _sqlConnection.QueryAsync(type, sql, param, transaction, commandTimeout, commandType);
        }

        public Task<object> QueryFirstAsync(Type type, string sql, object param = null, IDbTransaction transaction = null,
            int? commandTimeout = null, CommandType? commandType = null)
        {
            return _sqlConnection.QueryFirstAsync(type, sql, param, transaction, commandTimeout, commandType);
        }

        public Task<object> QueryFirstOrDefaultAsync(Type type, string sql, object param = null, IDbTransaction transaction = null,
            int? commandTimeout = null, CommandType? commandType = null)
        {
            return _sqlConnection.QueryFirstOrDefaultAsync(type, sql, param, transaction, commandTimeout, commandType);
        }

        public Task<object> QuerySingleAsync(Type type, string sql, object param = null, IDbTransaction transaction = null,
            int? commandTimeout = null, CommandType? commandType = null)
        {
            return _sqlConnection.QuerySingleAsync(type, sql, param, transaction, commandTimeout, commandType);
        }

        public Task<object> QuerySingleOrDefaultAsync(Type type, string sql, object param = null, IDbTransaction transaction = null,
            int? commandTimeout = null, CommandType? commandType = null)
        {
            return _sqlConnection.QuerySingleOrDefaultAsync(type, sql, param, transaction, commandTimeout, commandType);
        }

        public Task<IEnumerable<T>> QueryAsync<T>(CommandDefinition command)
        {
            return _sqlConnection.QueryAsync<T>(command);
        }

        public Task<IEnumerable<object>> QueryAsync(Type type, CommandDefinition command)
        {
            return _sqlConnection.QueryAsync(type, command);
        }

        public Task<object> QueryFirstAsync(Type type, CommandDefinition command)
        {
            return _sqlConnection.QueryFirstAsync(type, command);
        }

        public Task<object> QueryFirstOrDefaultAsync(Type type, CommandDefinition command)
        {
            return _sqlConnection.QueryFirstOrDefaultAsync(type, command);
        }       

        public Task<object> QuerySingleAsync(Type type, CommandDefinition command)
        {
            return _sqlConnection.QuerySingleAsync(type, command);
        }


        public Task<object> QuerySingleOrDefaultAsync(Type type, CommandDefinition command)
        {
            return _sqlConnection.QuerySingleAsync(type, command);
        }

        #endregion Async Methods

        #region Implementation of IDisposable

        /// <summary>
        /// Dispose
        /// </summary>
        public void Dispose()
        {
            _sqlConnection.Dispose();
        }

        #endregion Implementation of IDisposable
    }
}