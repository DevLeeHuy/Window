﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class myDB
    {
         SqlConnection con = new SqlConnection("Data Source=I1EU44RBUC8C4QE\\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True");
        public  SqlConnection getConnection()
        {
            return con;
        }

        public void openConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void closeConnection()
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
