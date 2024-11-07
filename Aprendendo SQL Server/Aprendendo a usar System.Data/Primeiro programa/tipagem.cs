using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiro_programa
{
    internal class Tipagem
    {
       public int Padding(DataColumn column)
        {
            int m = column.MaxLength;
            if (m > 0)
            {
                return m;
            }
            else 
            {
                m = 10;
                return m;
            }
        
        }
        
    }
}
