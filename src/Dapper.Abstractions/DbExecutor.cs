using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Dapper.Abstractions
{
    /// <summary>
    /// Class to create a Sql Executor
    /// </summary>
    public class DbExecutor : IDbExecutor
    {
        #region Members

        /// <summary>
        /// The SQL connection object
        /// </summary>
        private readonly IDbConnection _sqlConnection;

        #endregion Members

        /// <summary>
        /// Constructor for the SQL Executor
        /// </summary>
        /// <param name="sqlConnection"></param>
        public DbExecutor(IDbConnection sqlConnection)
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
            return SqlMapper.Query(_sqlConnection, sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TReturn>(string sql,
            Func<TFirst, TSecond, TThird, TReturn> map,
            object param = null,
            IDbTransaction transaction = null,
            bool buffered = true,
            string splitOn = "Id",
            int? commandTimeout = default(int?),
            CommandType? commandType = default(CommandType?))
        {
            return SqlMapper.Query(_sqlConnection, sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TReturn>(string sql,
            Func<TFirst, TSecond, TThird, TFourth, TReturn> map,
            object param = null,
            IDbTransaction transaction = null,
            bool buffered = true,
            string splitOn = "Id",
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return SqlMapper.Query(_sqlConnection, sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(string sql,
            Func<TFirst, TSecond, TThird, TFourth, TFifth, TReturn> map,
            object param = null,
            IDbTransaction transaction = null,
            bool buffered = true,
            string splitOn = "Id",
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return SqlMapper.Query(_sqlConnection, sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(string sql,
            Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn> map,
            object param = null,
            IDbTransaction transaction = null,
            bool buffered = true,
            string splitOn = "Id",
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return SqlMapper.Query(_sqlConnection, sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn>(string sql,
            Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn> map,
            object param = null,
            IDbTransaction transaction = null,
            bool buffered = true,
            string splitOn = "Id",
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return SqlMapper.Query(_sqlConnection, sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public IEnumerable<TReturn> Query<TReturn>(string sql, Type[] types,
            Func<object[], TReturn> map,
            object param = null,
            IDbTransaction transaction = null,
            bool buffered = true,
            string splitOn = "Id",
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return SqlMapper.Query(_sqlConnection, sql, types, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
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
            return SqlMapper.QuerySingleOrDefault<T>(_sqlConnection, sql, param, transaction, commandTimeout, commandType);
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
            var reader = SqlMapper.QueryMultiple(_sqlConnection, sql, param, transaction, commandTimeout, commandType);
            return new GridReaderAbstraction(reader);
        }

        public int Execute(CommandDefinition command)
        {
            return _sqlConnection.Execute(command);
        }

        public object ExecuteScalar(
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return SqlMapper.ExecuteScalar(_sqlConnection, sql, param, transaction, commandTimeout, commandType);
        }

        public T ExecuteScalar<T>(
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return SqlMapper.ExecuteScalar<T>(_sqlConnection, sql, param, transaction, commandTimeout, commandType);
        }

        public object ExecuteScalar(CommandDefinition command)
        {
            return SqlMapper.ExecuteScalar(_sqlConnection, command);
        }

        public T ExecuteScalar<T>(CommandDefinition command)
        {
            return SqlMapper.ExecuteScalar<T>(_sqlConnection, command);
        }

        public IDataReader ExecuteReader(
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return SqlMapper.ExecuteReader(_sqlConnection, sql, param, transaction, commandTimeout, commandType);
        }

        public IDataReader ExecuteReader(CommandDefinition command)
        {
            return SqlMapper.ExecuteReader(_sqlConnection, command);
        }

        public IDataReader ExecuteReader(CommandDefinition command, CommandBehavior commandBehavior)
        {
            return SqlMapper.ExecuteReader(_sqlConnection, command, commandBehavior);
        }

        public IEnumerable<object> Query(
            Type type,
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            bool buffered = true,
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return SqlMapper.Query(_sqlConnection, type, sql, param, transaction, buffered, commandTimeout, commandType);
        }

        public IEnumerable<T> Query<T>(CommandDefinition command)
        {
            return SqlMapper.Query<T>(_sqlConnection, command);
        }

        public T QueryFirst<T>(CommandDefinition command)
        {
            return SqlMapper.QueryFirst<T>(_sqlConnection, command);
        }

        public T QueryFirstOrDefault<T>(CommandDefinition command)
        {
            return SqlMapper.QueryFirstOrDefault<T>(_sqlConnection, command);
        }

        public T QuerySingle<T>(CommandDefinition command)
        {
            return SqlMapper.QuerySingle<T>(_sqlConnection, command);
        }

        public T QuerySingleOrDefault<T>(CommandDefinition command)
        {
            return SqlMapper.QuerySingleOrDefault<T>(_sqlConnection, command);
        }

        public IGridReader QueryMultiple(CommandDefinition command)
        {
            var reader = SqlMapper.QueryMultiple(_sqlConnection, command);
            return new GridReaderAbstraction(reader);
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
            return AdditionalDapper.Query(_sqlConnection, sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
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
            return SqlMapper.ExecuteAsync(_sqlConnection, sql, param, transaction, commandTimeout, commandType);
        }

        public Task<IEnumerable<dynamic>> QueryAsync(
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = default(int?),
            CommandType? commandType = default(CommandType?))
        {
            return SqlMapper.QueryAsync(_sqlConnection, sql, param, transaction, commandTimeout, commandType);
        }

        public Task<IEnumerable<T>> QueryAsync<T>(
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = default(int?),
            CommandType? commandType = default(CommandType?))
        {
            return SqlMapper.QueryAsync<T>(_sqlConnection, sql, param, transaction, commandTimeout, commandType);
        }

        public async Task<IGridReader> QueryMultipleAsync(
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = default(int?),
            CommandType? commandType = default(CommandType?))
        {
            var reader = await SqlMapper.QueryMultipleAsync(_sqlConnection, sql, param, transaction, commandTimeout, commandType).ConfigureAwait(false);
            return new GridReaderAbstraction(reader);
        }

        public Task<IEnumerable<dynamic>> QueryAsync(CommandDefinition command)
        {
            return SqlMapper.QueryAsync(_sqlConnection, command);
        }

        public Task<dynamic> QueryFirstAsync(CommandDefinition command)
        {
            return SqlMapper.QueryFirstAsync(_sqlConnection, command);
        }

        public Task<dynamic> QueryFirstOrDefaultAsync(CommandDefinition command)
        {
            return SqlMapper.QueryFirstOrDefaultAsync(_sqlConnection, command);
        }

        public Task<dynamic> QuerySingleAsync(CommandDefinition command)
        {
            return SqlMapper.QuerySingleAsync(_sqlConnection, command);
        }

        public Task<dynamic> QuerySingleOrDefaultAsync(CommandDefinition command)
        {
            return SqlMapper.QuerySingleOrDefaultAsync(_sqlConnection, command);
        }

        public Task<T> QueryFirstAsync<T>(
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return SqlMapper.QueryFirstAsync<T>(_sqlConnection, sql, param, transaction, commandTimeout, commandType);
        }

        public Task<T> QueryFirstOrDefaultAsync<T>(
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return SqlMapper.QueryFirstOrDefaultAsync<T>(_sqlConnection, sql, param, transaction, commandTimeout, commandType);
        }

        public Task<T> QuerySingleAsync<T>(
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return SqlMapper.QuerySingleAsync<T>(_sqlConnection, sql, param, transaction, commandTimeout, commandType);
        }

        public Task<T> QuerySingleOrDefaultAsync<T>(
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return SqlMapper.QuerySingleOrDefaultAsync<T>(_sqlConnection, sql, param, transaction, commandTimeout, commandType);
        }

        public Task<IEnumerable<object>> QueryAsync(
            Type type,
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return SqlMapper.QueryAsync(_sqlConnection, type, sql, param, transaction, commandTimeout, commandType);
        }

        public Task<object> QueryFirstAsync(
            Type type,
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return SqlMapper.QueryFirstAsync(_sqlConnection, type, sql, param, transaction, commandTimeout, commandType);
        }

        public Task<object> QueryFirstOrDefaultAsync(
            Type type,
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return SqlMapper.QueryFirstOrDefaultAsync(_sqlConnection, type, sql, param, transaction, commandTimeout, commandType);
        }

        public Task<object> QuerySingleAsync(
            Type type,
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return SqlMapper.QuerySingleAsync(_sqlConnection, type, sql, param, transaction, commandTimeout, commandType);
        }

        public Task<object> QuerySingleOrDefaultAsync(
            Type type,
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return SqlMapper.QuerySingleOrDefaultAsync(_sqlConnection, type, sql, param, transaction, commandTimeout, commandType);
        }

        public Task<dynamic> QuerySingleOrDefaultAsync(
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return SqlMapper.QuerySingleOrDefaultAsync(_sqlConnection, sql, param, transaction, commandTimeout, commandType);
        }

        public Task<IEnumerable<T>> QueryAsync<T>(CommandDefinition command)
        {
            return SqlMapper.QueryAsync<T>(_sqlConnection, command);
        }

        public Task<T> QueryFirstAsync<T>(CommandDefinition command)
        {
            return SqlMapper.QueryFirstAsync<T>(_sqlConnection, command);
        }

        public Task<T> QueryFirstOrDefaultAsync<T>(CommandDefinition command)
        {
            return SqlMapper.QueryFirstOrDefaultAsync<T>(_sqlConnection, command);
        }

        public Task<T> QuerySingleAsync<T>(CommandDefinition command)
        {
            return SqlMapper.QuerySingleAsync<T>(_sqlConnection, command);
        }

        public Task<T> QuerySingleOrDefaultAsync<T>(CommandDefinition command)
        {
            return SqlMapper.QuerySingleOrDefaultAsync<T>(_sqlConnection, command);
        }

        public Task<int> ExecuteAsync(CommandDefinition command)
        {
            return SqlMapper.ExecuteAsync(_sqlConnection, command);
        }

        public Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TReturn>(
            string sql,
            Func<TFirst, TSecond, TReturn> map,
            object param = null,
            IDbTransaction transaction = null,
            bool buffered = true,
            string splitOn = "Id",
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return SqlMapper.QueryAsync(_sqlConnection, sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TReturn>(
            CommandDefinition command,
            Func<TFirst, TSecond, TReturn> map,
            string splitOn = "Id")
        {
            return SqlMapper.QueryAsync(_sqlConnection, command, map, splitOn);
        }

        public Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TReturn>(
            string sql,
            Func<TFirst, TSecond, TThird, TReturn> map,
            object param = null,
            IDbTransaction transaction = null,
            bool buffered = true,
            string splitOn = "Id",
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return SqlMapper.QueryAsync(_sqlConnection, sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TReturn>(
            CommandDefinition command,
            Func<TFirst, TSecond, TThird, TReturn> map,
            string splitOn = "Id")
        {
            return SqlMapper.QueryAsync(_sqlConnection, command, map, splitOn);
        }

        public Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TReturn>(
            string sql,
            Func<TFirst, TSecond, TThird, TFourth, TReturn> map,
            object param = null,
            IDbTransaction transaction = null,
            bool buffered = true,
            string splitOn = "Id",
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return SqlMapper.QueryAsync(_sqlConnection, sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TReturn>(
            CommandDefinition command,
            Func<TFirst, TSecond, TThird, TFourth, TReturn> map,
            string splitOn = "Id")
        {
            return SqlMapper.QueryAsync(_sqlConnection, command, map, splitOn);
        }

        public Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(
            string sql,
            Func<TFirst, TSecond, TThird, TFourth, TFifth, TReturn> map,
            object param = null,
            IDbTransaction transaction = null,
            bool buffered = true,
            string splitOn = "Id",
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return SqlMapper.QueryAsync(_sqlConnection, sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(
            CommandDefinition command,
            Func<TFirst, TSecond, TThird, TFourth, TFifth, TReturn> map,
            string splitOn = "Id")
        {
            return SqlMapper.QueryAsync(_sqlConnection, command, map, splitOn);
        }

        public Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(
            string sql,
            Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn> map,
            object param = null,
            IDbTransaction transaction = null,
            bool buffered = true,
            string splitOn = "Id",
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return SqlMapper.QueryAsync(_sqlConnection, sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(
            CommandDefinition command,
            Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn> map,
            string splitOn = "Id")
        {
            return SqlMapper.QueryAsync(_sqlConnection, command, map, splitOn);
        }

        public Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn>(
            string sql,
            Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn> map,
            object param = null,
            IDbTransaction transaction = null,
            bool buffered = true,
            string splitOn = "Id",
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return SqlMapper.QueryAsync(_sqlConnection, sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn>(CommandDefinition command,
            Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn> map,
            string splitOn = "Id")
        {
            return SqlMapper.QueryAsync(_sqlConnection, command, map, splitOn);
        }

        public Task<IEnumerable<TReturn>> QueryAsync<TReturn>(
            string sql,
            Type[] types,
            Func<object[], TReturn> map,
            object param = null,
            IDbTransaction transaction = null,
            bool buffered = true,
            string splitOn = "Id",
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return SqlMapper.QueryAsync(_sqlConnection, sql, types, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public async Task<IGridReader> QueryMultipleAsync(CommandDefinition command)
        {
            var reader = await SqlMapper.QueryMultipleAsync(_sqlConnection, command).ConfigureAwait(false);
            return new GridReaderAbstraction(reader);
        }

        public Task<IDataReader> ExecuteReaderAsync(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return SqlMapper.ExecuteReaderAsync(_sqlConnection, sql, param, transaction, commandTimeout, commandType);
        }

        public Task<IDataReader> ExecuteReaderAsync(CommandDefinition command)
        {
            return SqlMapper.ExecuteReaderAsync(_sqlConnection, command);
        }

        public Task<IDataReader> ExecuteReaderAsync(CommandDefinition command, CommandBehavior commandBehavior)
        {
            return SqlMapper.ExecuteReaderAsync(_sqlConnection, command, commandBehavior);
        }

        public Task<object> ExecuteScalarAsync(
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return SqlMapper.ExecuteScalarAsync(_sqlConnection, sql, param, transaction, commandTimeout, commandType);
        }

        public Task<T> ExecuteScalarAsync<T>(
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return SqlMapper.ExecuteScalarAsync<T>(_sqlConnection, sql, param, transaction, commandTimeout, commandType);
        }

        public Task<object> ExecuteScalarAsync(CommandDefinition command)
        {
            return SqlMapper.ExecuteScalarAsync(_sqlConnection, command);
        }

        public Task<T> ExecuteScalarAsync<T>(CommandDefinition command)
        {
            return SqlMapper.ExecuteScalarAsync<T>(_sqlConnection, command);
        }

        public Task<IEnumerable<object>> QueryAsync(Type type, CommandDefinition command)
        {
            return SqlMapper.QueryAsync(_sqlConnection, type, command);
        }

        public Task<object> QueryFirstAsync(Type type, CommandDefinition command)
        {
            return SqlMapper.QueryFirstAsync(_sqlConnection, type, command);
        }

        public Task<object> QueryFirstOrDefaultAsync(Type type, CommandDefinition command)
        {
            return SqlMapper.QueryFirstOrDefaultAsync(_sqlConnection, type, command);
        }

        public Task<object> QuerySingleAsync(Type type, CommandDefinition command)
        {
            return SqlMapper.QuerySingleAsync(_sqlConnection, type, command);
        }

        public Task<object> QuerySingleOrDefaultAsync(Type type, CommandDefinition command)
        {
            return SqlMapper.QuerySingleAsync(_sqlConnection, type, command);
        }

        public Task<dynamic> QueryFirstAsync(
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return SqlMapper.QueryFirstAsync(_sqlConnection, sql, param, transaction, commandTimeout, commandType);
        }

        public Task<dynamic> QueryFirstOrDefaultAsync(
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return SqlMapper.QueryFirstOrDefaultAsync(_sqlConnection, sql, param, transaction, commandTimeout, commandType);
        }

        public Task<dynamic> QuerySingleAsync(
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return SqlMapper.QuerySingleAsync(_sqlConnection, sql, param, transaction, commandTimeout, commandType);
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
