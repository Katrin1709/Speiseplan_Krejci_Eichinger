using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Speiseplan_Krejci_Eichinger
{
    class Datenbank
    {
        private OleDbConnection verbindung;
        private OleDbCommand cmd;
        private string cn;

        public Datenbank()
        {
            cn = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = Speiseplan.accdb";
            verbindung = new OleDbConnection(cn);
            verbindung.Open();
        }

        public OleDbDataReader Einlesen(string sql)
        {
            try
            {
                cmd = new OleDbCommand(sql, verbindung);
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                throw new Exception("Fehler beim Einlesen" + ex.Message);
            }
        }

        public void Ausfuehren(string sql)
        {
            try
            {
                cmd = new OleDbCommand(sql, verbindung);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Fehler beim Einlesen" + ex.Message);
            }
        }

        public Int32 BerechnenInt(string sql)
        {
            try
            {
                cmd = new OleDbCommand(sql, verbindung);
                //Int32 x = Convert.ToInt32(cmd.ExecuteScalar());
                //return x; 
                return (Int32)cmd.ExecuteScalar();

            }
            catch (Exception ex)
            {
                throw new Exception("Fehler beim Berechnen mit Int" + ex.Message);
            }
        }
        public Double BerechnenDouble(string sql)
        {
            try
            {
                cmd = new OleDbCommand(sql, verbindung);
                return (Double)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Fehler beim Berechnen mit Double" + ex.Message);
            }
        }
    
    }
}
