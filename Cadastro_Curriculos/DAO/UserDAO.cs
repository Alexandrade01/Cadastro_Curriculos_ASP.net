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
           /*  string sql =
            "insert into Cadastros(CPF, nome, endereco, numero, DDD, telefone, email, salario, cargo,instituicao1, formacao1, conclusao1, instituicao2, formacao2, conclusao2, instituicao3, formacao3, conclusao3, instituicao4, formacao4, conclusao4, instituicao5, formacao5, conclusao5,empresa1, funcao1, empresa2, funcao2, empresa3, funcao3,idioma, nivel" +
           "values(@CPF, @nome, @endereco, @numero, @DDD, @telefone, @email, @salario, @cargo,@instituicao1, @formacao1, @conclusao1, @instituicao2, @formacao2, @conclusao2, @instituicao3, @formacao3, @conclusao3, @instituicao4, @formacao4, @conclusao4, @instituicao5, @formacao5, @conclusao5, @empresa1, @funcao1, @empresa2, @funcao2, @empresa3, @funcao3, @idioma, @nivel)";
           */

            string sql = "insert into Cadastros(Id,CPF, nome)" +
            "values(@Id, @CPF, @nome)";
            ExecutaSql(sql, CriaParametros(user));
        }


         public void Alterar(UserViewModel aluno)
         {
             string sql =
             "update Cadastros set " +
             "CPF = @CPF, " +
             "nome = @nome " +
             "where id = @id";

             ExecutaSql(sql, CriaParametros(aluno));
         } 

        private SqlParameter[] CriaParametros(UserViewModel user)
        {
            SqlParameter[] parametros = new SqlParameter[3];
            parametros[0] = new SqlParameter("Id", user.Id);
            parametros[1] = new SqlParameter("CPF", user.CPF);
            parametros[2] = new SqlParameter("nome", user.Nome);
           /* parametros[2] = new SqlParameter("endereco", user.Endereco);
            parametros[3] = new SqlParameter("numero", user.Numero);
            parametros[4] = new SqlParameter("DDD", user.DDD);
            parametros[5] = new SqlParameter("telefone", user.Telefone);
            parametros[6] = new SqlParameter("email", user.Email);
            parametros[7] = new SqlParameter("salario", user.Salario);
            parametros[8] = new SqlParameter("cargo", user.Cargo);
            parametros[9] = new SqlParameter("instituicao1", user.Instituicao1);
            parametros[10] = new SqlParameter("formacao1", user.Formacao1);
            parametros[11] = new SqlParameter("conclusao1", user.Conclusao1);
            parametros[12] = new SqlParameter("instituicao2", user.Instituicao2);
            parametros[13] = new SqlParameter("formacao2", user.Formacao2);
            parametros[14] = new SqlParameter("conclusao2", user.Conclusao2);
            parametros[15] = new SqlParameter("instituicao3", user.Instituicao3);
            parametros[16] = new SqlParameter("formacao3", user.Formacao3);
            parametros[17] = new SqlParameter("conclusao3", user.Conclusao3);
            parametros[18] = new SqlParameter("instituicao4", user.Instituicao4);
            parametros[19] = new SqlParameter("formacao4", user.Formacao4);
            parametros[20] = new SqlParameter("conclusao4", user.Conclusao4);
            parametros[21] = new SqlParameter("instituicao5", user.Instituicao5);
            parametros[22] = new SqlParameter("formacao5", user.Formacao5);
            parametros[23] = new SqlParameter("conclusao5", user.Conclusao5);
            parametros[24] = new SqlParameter("empresa1", user.Empresa1);
            parametros[25] = new SqlParameter("funcao1", user.Funcao1);
            parametros[26] = new SqlParameter("empresa2", user.Empresa2);
            parametros[27] = new SqlParameter("funcao2", user.Funcao2);
            parametros[28] = new SqlParameter("empresa3", user.Empresa3);
            parametros[29] = new SqlParameter("funcao3", user.Funcao3);
            parametros[30] = new SqlParameter("Idioma", user.Idioma);
            parametros[31] = new SqlParameter("Nivel", user.Nivel); */
            

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
            /* a.CidadeId = Convert.ToInt32(registro["cidadeId"]);
            a.DataNascimento = Convert.ToDateTime(registro["dataNascimento"]);
            a.Mensalidade = Convert.ToDouble(registro["mensalidade"]); */
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
            string sql = "select * from Cadastros where id = "+id;
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);

            foreach (DataRow registro in tabela.Rows) {
                userReturn = MontaAluno(registro);
            }
                
            return userReturn;
        }


    }
}
