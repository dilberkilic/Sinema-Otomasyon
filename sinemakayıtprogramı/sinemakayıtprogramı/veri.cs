using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;


namespace sinemakayıtprogramı



{
    class veri
    {
        public OleDbConnection baglan()
        {
            OleDbConnection bg=new OleDbConnection("Provider=microsoft.ace.oledb.12.0;data source = ..//..//sinema.accdb");
            bg.Open();
            return bg;

        }
        public OleDbConnection kapat()
        {
            OleDbConnection bg = new OleDbConnection("Provider=microsoft.ace.oledb.12.0;data source = ..//..//sinema.accdb");
            bg.Close();
            return bg;

        }
        public OleDbCommand komut(string sql)
        {
            OleDbCommand komut = new OleDbCommand(sql, this.baglan());
            komut.ExecuteNonQuery();
            return komut;

        }
        public OleDbDataReader oku(string sql)
        {
            OleDbCommand komut = new OleDbCommand(sql, this.baglan());
            OleDbDataReader oku = komut.ExecuteReader();
            return oku;
        }
        public DataSet tbl(string sql)
        {
            OleDbDataAdapter da = new OleDbDataAdapter(sql, this.baglan());
            DataSet ds = new DataSet();
            da.Fill(ds, "sanal");
            return ds;


        }
    }
}
