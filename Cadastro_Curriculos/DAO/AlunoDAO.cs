using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadAlunoMVC.Models;

namespace CadAlunoMVC.DAO
{
    public class AlunoDAO
    {
        /// <summary>
        /// Método para inserir um aluno no BD
        /// </summary>
        /// <param name="aluno">objeto aluno com todas os atributos preenchidos</param>
        public void Inserir(AlunoViewModel aluno)
        {
            string sql =
           "insert into alunos(id, nome, mensalidade, cidadeId, dataNascimento)" +
           "values ( @id, @nome, @mensalidade, @cidadeId, @dataNascimento)";

            ExecutaSql(sql, CriaParametros(aluno));
        }


        public void Alterar(AlunoViewModel aluno)
        {
            string sql =
            "update alunos set nome = @nome, " +
            "mensalidade = @mensalidade, " +
            "cidadeId = @cidadeId" +
            "dataNascimento = @dataNascimento where id = @id";

            ExecutaSql(sql, CriaParametros(aluno));
        }

        private SqlParameter[] CriaParametros(AlunoViewModel user)
        {
            SqlParameter[] parametros = new SqlParameter[32];
            parametros[0] = new SqlParameter("id", user.Id);
            parametros[1] = new SqlParameter("nome", user.Nome);
            parametros[2] = new SqlParameter("mensalidade", user.Mensalidade);
            parametros[3] = new SqlParameter("cidadeId", user.CidadeId);
            parametros[4] = new SqlParameter("dataNascimento", user.DataNascimento);

            return parametros;
        }


        public void Excluir(int id)
        {
            string sql = "delete alunos where id =" + id;

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

        private AlunoViewModel MontaAluno(DataRow registro)
        {
            AlunoViewModel a = new AlunoViewModel();
            a.Id = Convert.ToInt32(registro["id"]);
            a.Nome = registro["nome"].ToString();
            a.CidadeId = Convert.ToInt32(registro["cidadeId"]);
            a.DataNascimento = Convert.ToDateTime(registro["dataNascimento"]);
            a.Mensalidade = Convert.ToDouble(registro["mensalidade"]);
            return a;
        }




        public AlunoViewModel Consulta(int id)
        {
            string sql = "select * from alunos where id = " + id;
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);

            if (tabela.Rows.Count == 0)
                return null;
            else
                return MontaAluno(tabela.Rows[0]);
        }



        public List<AlunoViewModel> Listagem()
        {
            List<AlunoViewModel> lista = new List<AlunoViewModel>();

            string sql = "select * from alunos order by nome";
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);

            foreach (DataRow registro in tabela.Rows)
                lista.Add(MontaAluno(registro));
            return lista;
        }


        
    }
}
