﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadAlunoMVC.DAO
{
    public static class ConexaoBD
    {
        /// <summary>
        /// Método Estático que retorna um conexao aberta com o BD
        /// </summary>
        /// <returns>Conexão aberta</returns>
        public static SqlConnection GetConexao()
        {
            string strCon = "Data Source=DESKTOP-5K81H18\\SQLEXPRESS; Database =auladb; user id = sa; password=1234567";
            SqlConnection conexao = new SqlConnection(strCon);
            conexao.Open();
            return conexao;
        }

    }
}
