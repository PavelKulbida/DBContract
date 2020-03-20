using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBContract.Test
{
  public interface IDataStorage
  {
    int GetCount();

    string GetHi();
  }
}
