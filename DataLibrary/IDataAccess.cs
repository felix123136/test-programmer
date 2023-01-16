using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace employeedata.DataLibrary
{
    public interface IDataAccess
    {
        Task<List<T>> LoadData<T, U>(string sql, U parameters, string connectionString);
        Task SaveData<T>(string sql, T parameters, string connectionString);
    }
}