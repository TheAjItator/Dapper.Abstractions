using Oracle.ManagedDataAccess.Client;
using System;

namespace Dapper.Abstractions.Oracle;
public class OracleExecutorFactory {
    #region Members

    private readonly string _connectionString;

    #endregion Members

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="connectionString">The connection for the required database</param>
    /// <exception cref="ArgumentNullException"></exception>
    public OracleExecutorFactory(string connectionString) {
        if (string.IsNullOrWhiteSpace(connectionString)) {
            throw new ArgumentNullException(nameof(connectionString));
        }

        _connectionString = connectionString;
    }

    /// <summary>
    /// Create an open database connection
    /// </summary>
    /// <returns>The newly created database connection</returns>
    public IDbExecutor CreateExecutor() {
        var dbConnection = new OracleConnection(_connectionString);
        dbConnection.Open();

        return new DbExecutor(dbConnection);
    }
}
