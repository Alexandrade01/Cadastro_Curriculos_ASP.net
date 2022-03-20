using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cadastro_Curriculos.Models;

namespace Cadastro_Curriculos.DAO
{
    public class UserDAO
    {
        public void Inserir(UserViewModel user)
        {
            string sql =
           "insert into Cadastros(Id, CPF, Nome, endereco, numero, DDD, telefone, email, salario, cargo, instituicao1, formacao1, conclusao1, instituicao2, formacao2, conclusao2, instituicao3, formacao3, conclusao3, instituicao4, formacao4, conclusao4, instituicao5, formacao5, conclusao5, empresa1, funcao1, empresa2, funcao2, empresa3, funcao3, idioma, nivel) " +
          "values(@Id, @CPF, @Nome, @endereco, @numero, @DDD, @telefone, @email, @salario, @cargo, @instituicao1, @formacao1, @conclusao1, @instituicao2, @formacao2, @conclusao2, @instituicao3, @formacao3, @conclusao3, @instituicao4, @formacao4, @conclusao4, @instituicao5, @formacao5, @conclusao5, @empresa1, @funcao1, @empresa2, @funcao2, @empresa3, @funcao3, @idioma, @nivel)";

            ExecutaSql(sql, CriaParametros(user));
        }


        public void Alterar(UserViewModel aluno)
        {
            string sql =
            "update Cadastros set " +
            "CPF = @CPF, " +
            "nome = @nome, " +
            "endereco = @endereco, " +
            "numero = @numero, " +
            "DDD = @DDD, " +
            "telefone = @telefone, " +
            "email = @email, " +
            "salario = @salario, " +
            "cargo = @cargo, " +
            "instituicao1 = @instituicao1, " +
            "formacao1 = @formacao1, " +
            "conclusao1 = @conclusao1, " +
             "instituicao2 = @instituicao2, " +
            "formacao2 = @formacao2, " +
            "conclusao2 = @conclusao2, " +
             "instituicao3 = @instituicao3, " +
            "formacao3 = @formacao3, " +
            "conclusao3 = @conclusao3, " +
             "instituicao4 = @instituicao4, " +
            "formacao4 = @formacao4, " +
            "conclusao4 = @conclusao4, " +
            "instituicao5 = @instituicao5, " +
            "formacao5 = @formacao5, " +
            "conclusao5 = @conclusao5, " +
            "empresa1 = @empresa1, " +
            "funcao1 = @funcao1, " +
            "empresa2 = @empresa2, " +
            "funcao2 = @funcao2, " +
            "empresa3 = @empresa3, " +
            "funcao3 = @funcao3, " +
            "idioma = @idioma, " +
            "nivel = @nivel " +

            "where id = @id";

            ExecutaSql(sql, CriaParametros(aluno));
        }

        private SqlParameter[] CriaParametros(UserViewModel user)
        {
            SqlParameter[] parametros = new SqlParameter[33];

            parametros[0] = new SqlParameter("Id", user.Id);
            parametros[1] = new SqlParameter("CPF", user.CPF);
            parametros[2] = new SqlParameter("Nome", user.Nome);
            if (user.Endereco == null) { parametros[3] = new SqlParameter("endereco", DBNull.Value); }
            else { parametros[3] = new SqlParameter("endereco", user.Endereco); }

            if (user.Numero == null) { parametros[4] = new SqlParameter("numero", DBNull.Value); }
            else { parametros[4] = new SqlParameter("numero", user.Numero); }

            if (user.DDD == null) { parametros[5] = new SqlParameter("DDD", DBNull.Value); }
            else { parametros[5] = new SqlParameter("DDD", user.DDD); }

            if (user.Telefone == null) { parametros[6] = new SqlParameter("telefone", DBNull.Value); }
            else { parametros[6] = new SqlParameter("telefone", user.Telefone); }

            if (user.Email == null) { parametros[7] = new SqlParameter("email", DBNull.Value); }
            else { parametros[7] = new SqlParameter("email", user.Email); }

            if (user.Salario == null) { parametros[8] = new SqlParameter("salario", DBNull.Value); }
            else { parametros[8] = new SqlParameter("salario", user.Salario); }

            if (user.Cargo == null) { parametros[9] = new SqlParameter("cargo", DBNull.Value); }
            else { parametros[9] = new SqlParameter("cargo", user.Cargo); }

            parametros[10] = new SqlParameter("instituicao1", user.Instituicao1);
            parametros[11] = new SqlParameter("formacao1", user.Formacao1);
            parametros[12] = new SqlParameter("conclusao1", user.Conclusao1);

            if (user.Instituicao2 == null) { parametros[13] = new SqlParameter("instituicao2", DBNull.Value); }
            else { parametros[13] = new SqlParameter("instituicao2", user.Instituicao2); }

            if (user.Formacao2 == null) { parametros[14] = new SqlParameter("formacao2", DBNull.Value); }
            else { parametros[14] = new SqlParameter("formacao2", user.Formacao2); }

            if (user.Conclusao2 == null) { parametros[15] = new SqlParameter("conclusao2", DBNull.Value); }
            else { parametros[15] = new SqlParameter("conclusao2", user.Conclusao2); }


            if (user.Instituicao3 == null) { parametros[16] = new SqlParameter("instituicao3", DBNull.Value); }
            else { parametros[16] = new SqlParameter("instituicao3", user.Instituicao3); }

            if (user.Formacao3 == null) { parametros[17] = new SqlParameter("formacao3", DBNull.Value); }
            else { parametros[17] = new SqlParameter("formacao3", user.Formacao2); }

            if (user.Conclusao3 == null) { parametros[18] = new SqlParameter("conclusao3", DBNull.Value); }
            else { parametros[18] = new SqlParameter("conclusao3", user.Conclusao3); }

            if (user.Instituicao4 == null) { parametros[19] = new SqlParameter("instituicao4", DBNull.Value); }
            else { parametros[19] = new SqlParameter("instituicao4", user.Instituicao4); }

            if (user.Formacao4 == null) { parametros[20] = new SqlParameter("formacao4", DBNull.Value); }
            else { parametros[20] = new SqlParameter("formacao4", user.Formacao4); }

            if (user.Conclusao4 == null) { parametros[21] = new SqlParameter("conclusao4", DBNull.Value); }
            else { parametros[21] = new SqlParameter("conclusao4", user.Conclusao4); }

            if (user.Instituicao5 == null) { parametros[22] = new SqlParameter("instituicao5", DBNull.Value); }
            else { parametros[22] = new SqlParameter("instituicao5", user.Instituicao5); }

            if (user.Formacao5 == null) { parametros[23] = new SqlParameter("formacao5", DBNull.Value); }
            else { parametros[23] = new SqlParameter("formacao5", user.Formacao5); }

            if (user.Conclusao5 == null) { parametros[24] = new SqlParameter("conclusao5", DBNull.Value); }
            else { parametros[24] = new SqlParameter("conclusao5", user.Conclusao5); }

            if (user.Empresa1 == null) { parametros[25] = new SqlParameter("empresa1", DBNull.Value); }
            else { parametros[25] = new SqlParameter("empresa1", user.Empresa1); }

            if (user.Funcao1 == null) { parametros[26] = new SqlParameter("funcao1", DBNull.Value); }
            else { parametros[26] = new SqlParameter("funcao1", user.Funcao1); }

            if (user.Empresa2 == null) { parametros[27] = new SqlParameter("empresa2", DBNull.Value); }
            else { parametros[27] = new SqlParameter("empresa2", user.Empresa2); }

            if (user.Funcao2 == null) { parametros[28] = new SqlParameter("funcao2", DBNull.Value); }
            else { parametros[28] = new SqlParameter("funcao2", user.Funcao2); }

            if (user.Empresa3 == null) { parametros[29] = new SqlParameter("empresa3", DBNull.Value); }
            else { parametros[29] = new SqlParameter("empresa3", user.Empresa3); }

            if (user.Funcao3 == null) { parametros[30] = new SqlParameter("funcao3", DBNull.Value); }
            else { parametros[30] = new SqlParameter("funcao3", user.Funcao3); }

            if (user.Idioma == null) { parametros[31] = new SqlParameter("idioma", DBNull.Value); }
            else { parametros[31] = new SqlParameter("idioma", user.Idioma); }

            if (user.Nivel == null) { parametros[32] = new SqlParameter("nivel", DBNull.Value); }
            else { parametros[32] = new SqlParameter("nivel", user.Nivel); }

            return parametros;
        }


        public void Excluir(int id)
        {
            string sql = "delete Cadastros where Id =" + id;

            ExecutaSql(sql, null);
        }


        public void ExecutaSql(string sql, SqlParameter[] parametros)
        {
            using (var conexao = ConexaoBD.GetConexao())
            {
                using (var comando = new SqlCommand(sql, conexao))
                {
                    if (parametros != null)
                        comando.Parameters.AddRange(parametros);
                    comando.ExecuteNonQuery();
                }
                conexao.Close();
            }
        }

        private UserViewModel MontaAluno(DataRow registro)
        {
            UserViewModel a = new UserViewModel();
            a.Id = Convert.ToInt32(registro["Id"]);
            a.CPF = registro["CPF"].ToString();
            a.Nome = registro["nome"].ToString();
            if (registro["endereco"] != DBNull.Value) { a.Endereco = registro["endereco"].ToString(); }
            if (registro["numero"] != DBNull.Value) { a.Numero = Convert.ToInt32(registro["numero"]); };
            if (registro["DDD"] != DBNull.Value) { a.DDD = Convert.ToInt32(registro["DDD"]); };
            if (registro["telefone"] != DBNull.Value) { a.Telefone = Convert.ToInt32(registro["telefone"]); };
            if (registro["email"] != DBNull.Value) { a.Email = registro["email"].ToString(); }
            if (registro["salario"] != DBNull.Value) { a.Salario = Convert.ToDouble(registro["salario"]); }
            if (registro["cargo"] != DBNull.Value) { a.Cargo = registro["cargo"].ToString(); }
            if (registro["instituicao1"] != DBNull.Value) { a.Instituicao1 = registro["instituicao1"].ToString(); }
            if (registro["formacao1"] != DBNull.Value) { a.Formacao1 = registro["formacao1"].ToString(); }
            if (registro["conclusao1"] != DBNull.Value) { a.Conclusao1 = Convert.ToDateTime(registro["conclusao1"]); }
            if (registro["instituicao2"] != DBNull.Value) { a.Instituicao2 = registro["instituicao2"].ToString(); }
            if (registro["formacao2"] != DBNull.Value) { a.Formacao2 = registro["formacao2"].ToString(); }
            if (registro["conclusao2"] != DBNull.Value) { a.Conclusao2 = Convert.ToDateTime(registro["conclusao2"]); }
            if (registro["instituicao3"] != DBNull.Value) { a.Instituicao3 = registro["instituicao3"].ToString(); }
            if (registro["formacao3"] != DBNull.Value) { a.Formacao3 = registro["formacao3"].ToString(); }
            if (registro["conclusao3"] != DBNull.Value) { a.Conclusao3 = Convert.ToDateTime(registro["conclusao3"]); }
            if (registro["instituicao4"] != DBNull.Value) { a.Instituicao4 = registro["instituicao4"].ToString(); }
            if (registro["formacao4"] != DBNull.Value) { a.Formacao4 = registro["formacao4"].ToString(); }
            if (registro["conclusao4"] != DBNull.Value) { a.Conclusao4 = Convert.ToDateTime(registro["conclusao4"]); }
            if (registro["instituicao5"] != DBNull.Value) { a.Instituicao5 = registro["instituicao5"].ToString(); }
            if (registro["formacao5"] != DBNull.Value) { a.Formacao5 = registro["formacao5"].ToString(); }
            if (registro["conclusao5"] != DBNull.Value) { a.Conclusao5 = Convert.ToDateTime(registro["conclusao5"]); }
            if (registro["empresa1"] != DBNull.Value) { a.Empresa1 = registro["empresa1"].ToString(); }
            if (registro["funcao1"] != DBNull.Value) { a.Funcao1 = registro["funcao1"].ToString(); }
            if (registro["empresa2"] != DBNull.Value) { a.Empresa2 = registro["empresa2"].ToString(); }
            if (registro["funcao2"] != DBNull.Value) { a.Funcao2 = registro["funcao2"].ToString(); }
            if (registro["empresa3"] != DBNull.Value) { a.Empresa3 = registro["empresa3"].ToString(); }
            if (registro["funcao3"] != DBNull.Value) { a.Funcao3 = registro["funcao3"].ToString(); }
            if (registro["idioma"] != DBNull.Value) { a.Idioma = registro["idioma"].ToString(); }
            if (registro["nivel"] != DBNull.Value) { a.Nivel = registro["nivel"].ToString(); }

            return a;
        }




        public UserViewModel Consulta(int id)
        {
            string sql = "select * from Cadastros where id = " + id;
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);

            if (tabela.Rows.Count == 0)
                return null;
            else
                return MontaAluno(tabela.Rows[0]);
        }




        public List<UserViewModel> Listagem()
        {
            List<UserViewModel> lista = new List<UserViewModel>();

            string sql = "select * from Cadastros order by nome";
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);

            foreach (DataRow registro in tabela.Rows)
                lista.Add(MontaAluno(registro));
            return lista;
        }

        public int ProximoId()
        {
            string sql = "select isnull(max(id) +1, 1) as 'MAIOR' from Cadastros";
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);
            return Convert.ToInt32(tabela.Rows[0]["MAIOR"]);
        }

        public UserViewModel Exibir(int id)
        {

            UserViewModel userReturn = new UserViewModel();
            string sql = "select * from Cadastros where id = " + id;
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);

            foreach (DataRow registro in tabela.Rows)
            {
                userReturn = MontaAluno(registro);
            }

            return userReturn;
        }


    }
}
