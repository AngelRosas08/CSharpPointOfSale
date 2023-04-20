using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Elesctronicos_Ross
{
    internal class conection
    {
		public static void Conectar()
		{
			SqlConnection cn = new SqlConnection("SERVER=PC1;DATABASE=Electronicos_Ross;Integrated security=true");
			cn.Open();
			//return cn;
		}
	}
}

