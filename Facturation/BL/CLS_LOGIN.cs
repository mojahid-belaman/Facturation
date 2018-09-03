using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Facturation.BL
{
    class CLS_LOGIN
    {
        public int SP_LOGING(string ID, string PSW)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

            SqlParameter paramReturn = new SqlParameter("@returnedvalue", SqlDbType.Int);

            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            param[1] = new SqlParameter("@PSW", SqlDbType.VarChar, 50);
            param[1].Value = PSW;

            int i = dal.ExecuteNonQuery2("SP_LOGIN", paramReturn, param);

            return i;
            
        }
    }
}
