using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro_Curriculos.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string? Endereco { get; set; }
        public int? Numero { get; set; }
        public int? DDD { get; set; }
        public int? Telefone { get; set; }
        public string? Email { get; set; }
        public double? Salario { get; set; }
        public string? Cargo { get; set; }
        public string Instituicao1 { get; set; }
        public string Formacao1 { get; set; }
        public DateTime Conclusao1 { get; set; }
        public string? Instituicao2 { get; set; }
        public string? Formacao2 { get; set; }
        public DateTime? Conclusao2 { get; set; }
        public string? Instituicao3 { get; set; }
        public string? Formacao3 { get; set; }
        public DateTime? Conclusao3 { get; set; }
        public string? Instituicao4 { get; set; }
        public string? Formacao4 { get; set; }
        public DateTime? Conclusao4 { get; set; }
        public string? Instituicao5 { get; set; }
        public string? Formacao5 { get; set; }
        public DateTime? Conclusao5 { get; set; }

        public string? Empresa1 { get; set; }
        public string? Funcao1 { get; set; }
        public string? Empresa2 { get; set; }
        public string? Funcao2 { get; set; }
        public string? Empresa3 { get; set; }
        public string? Funcao3 { get; set; }

        public string? Idioma { get; set; }
        public string? Nivel { get; set; }

        public string ValidaData(DateTime? time)
        {

            if (time == null) { return null; }
            else { return time.Value.ToShortDateString(); }
        }

        public string CheckNull(DateTime? time) {

            if (time == null) { return null; }
            else { return time.GetValueOrDefault().ToString("yyyy-MM-dd"); }
        }
    }
}
