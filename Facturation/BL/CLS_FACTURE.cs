using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Facturation.BL
{
    class CLS_FACTURE
    {
        public DataTable LAST_FACTURE()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = dal.SelectData("LAST_FACTURE", null);
            return dt;
        }

        public DataTable ALL_CLIENT()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = dal.SelectData("ALL_CLIENT", null);
            return dt;
        }

        public void ADD_CLIENT(int Code_cl, string nom, string adresse, string ville, decimal solde)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[5];
            dal.open();

            param[0] = new SqlParameter("@CODE_CL", SqlDbType.Int);
            param[0].Value = Code_cl;
            param[1] = new SqlParameter("@NOM_CL", SqlDbType.VarChar, 25);
            param[1].Value = nom;
            param[2] = new SqlParameter("@ADRESSE", SqlDbType.VarChar, 50);
            param[2].Value = adresse;
            param[3] = new SqlParameter("@VILLE", SqlDbType.VarChar, 50);
            param[3].Value = ville;
            param[4] = new SqlParameter("@SOLDE", SqlDbType.Money);
            param[4].Value = solde;

            dal.ExecutCommand("ADD_CLIENT", param);
            dal.close();
        }

        public DataTable ALL_ARTICLE()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = dal.SelectData("ALL_ARTICLE", null);
            return dt;
        }

        public void ADD_ARTICLE(string REF, string DESIGNATION, decimal PU, int QS)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[4];
            dal.open();

            param[0] = new SqlParameter("@REF", SqlDbType.VarChar, 50);
            param[0].Value = REF;
            param[1] = new SqlParameter("@DESIGNATION", SqlDbType.VarChar, 50);
            param[1].Value = DESIGNATION;
            param[2] = new SqlParameter("@PU", SqlDbType.Float);
            param[2].Value = PU;
            param[3] = new SqlParameter("@QUT_ST", SqlDbType.Int);
            param[3].Value = QS;

            dal.ExecutCommand("ADD_ARTICLE", param);
            dal.close();
        }

        public void ADD_FACTURE(int NO_FACTURE, DateTime DATE_FACTURE, decimal MONTANT_FACTURE, decimal MONTANT_RESTE, int CODE_CL)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();

            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@NO_FACTURE", SqlDbType.Int);
            param[0].Value = NO_FACTURE;
            param[1] = new SqlParameter("@DATE_FACTURE", SqlDbType.Date);
            param[1].Value = DATE_FACTURE;
            param[2] = new SqlParameter("@MONTANT_FACTURE", SqlDbType.Money);
            param[2].Value = MONTANT_FACTURE;
            param[3] = new SqlParameter("@MONTANT_RESTE", SqlDbType.Money);
            param[3].Value = MONTANT_RESTE;
            param[4] = new SqlParameter("@CODE_CL", SqlDbType.Int);
            param[4].Value = CODE_CL;

            dal.ExecutCommand("ADD_FACTURE", param);
            dal.close();
        }

        public void ADD_CONTIENT(string REF, int NO_FACTURE, int QUT_CD)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();

            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@REF", SqlDbType.VarChar, 50);
            param[0].Value = REF;
            param[1] = new SqlParameter("@NO_FACTURE", SqlDbType.Int);
            param[1].Value = NO_FACTURE;
            param[2] = new SqlParameter("@QUT_CD", SqlDbType.Int);
            param[2].Value = QUT_CD;

            dal.ExecutCommand("ADD_CONTIENT", param);
            dal.close();
        }

        public DataTable VERIFIER_ID(string REF)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@REF", SqlDbType.VarChar, 50);
            param[0].Value = REF;
            dt = dal.SelectData("VERIFIER_ID", param);
            return dt;
        }

        public DataTable VERIFIER_ID_CLIENT(int CODE_CL)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@CODE_CL", SqlDbType.Int);
            param[0].Value = CODE_CL;
            dt = dal.SelectData("VERIFIER_ID_CLIENT", param);
            return dt;
        }

        public DataTable VERIFY_QUTESTOCK(string REF, int QUT_ST)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@REF", SqlDbType.VarChar, 50);
            param[0].Value = REF;
            param[1] = new SqlParameter("@QUT_ST", SqlDbType.Int);
            param[1].Value = QUT_ST;

            dt = dal.SelectData("VERIFY_QUTESTOCK", param);
            return dt;
        }

        public DataTable LAST_FACTURE_PRINT()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = dal.SelectData("LAST_FACTURE_PRINT", null);
            return dt;
        }

        public DataTable PRINT_DETAIL_FACTURE(int NO_FACTURE)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@NO_FACTURE", SqlDbType.Int);
            param[0].Value = NO_FACTURE;

            dt = dal.SelectData("PRINT_DETAIL_FACTURE", param);
            return dt;
        }

    }
}
