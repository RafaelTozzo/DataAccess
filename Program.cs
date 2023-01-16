using BaltaDataAccess.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace BaltaDataAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            // AdoNet.AdoNetTest();

            DapperDataAccess.DapperTest();
        }
    }
}