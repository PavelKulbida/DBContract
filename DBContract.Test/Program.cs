using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBContract.Test
{
  class Program
  {
    static void Main(string[] args)
    {
      var connection = new System.Data.SqlClient.SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

      connection.Open();

      var sc = connection.rpc<IDataStorage>();


      Console.WriteLine(sc.GetHi());


      Console.ReadLine();
    }
  }
}
