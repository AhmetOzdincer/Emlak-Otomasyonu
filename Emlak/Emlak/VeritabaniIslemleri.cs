﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace VTIslemleri
{
    class VeritabaniIslemleri
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=EmlakOtomasyon;Integrated Security=True");
        public DataTable datatbl = new DataTable();
        public SqlDataAdapter adtr = new SqlDataAdapter();
        public SqlCommand sqlkomut = new SqlCommand();


        public DataTable Select(string sorgu)
        {
            if (baglan() == true)
            {
                datatbl = new DataTable();
                sqlkomut.Connection = baglanti;
                sqlkomut.CommandText = sorgu;
                adtr.SelectCommand = sqlkomut;
                adtr.Fill(datatbl);
                baglantiKapat();
                return datatbl;
            }
            else
                return null;
        }

        public int Insert(string sorgu)
        {
            if (baglan() == true)
            {
                sqlkomut.Connection = baglanti;
                sqlkomut.CommandText = sorgu + " select SCOPE_IDENTITY() a";
                //int sayi = sqlkomut.ExecuteNonQuery();

               // sqlkomut.CommandText = "";
                DataTable dt =  new DataTable();
                adtr.SelectCommand = sqlkomut;
                adtr.Fill(dt);

                baglantiKapat();

                if (dt.Rows.Count == 0)
                    return 0;
                else
                    return Convert.ToInt32(dt.Rows[0][0]);
            }
            else
                return 0;
        }

        public int UpdateDelete(string sorgu)
        {
            if (baglan() == true)
            {
                sqlkomut.Connection = baglanti;
                sqlkomut.CommandText = sorgu;
                int sayi = sqlkomut.ExecuteNonQuery();
                baglantiKapat();
                return sayi;
            }
            else
                return 0;
        }

        public int SorguCalistir(string sorgu)
        {
            if (baglan() == true)
            {
                sqlkomut.Connection = baglanti;
                sqlkomut.CommandText = sorgu;
                int sayi = sqlkomut.ExecuteNonQuery();
                baglantiKapat();
                return sayi;
            }
            else
                return 0;

        }


        bool baglan()
        {
            try
            {
                baglanti.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        void baglantiKapat()
        {
            try
            {
                baglanti.Close();
            }
            catch
            {
 
            }
        }

    }
}
