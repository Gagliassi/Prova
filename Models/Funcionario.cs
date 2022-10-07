using System;
using System.ComponentModel.DataAnnotations;

namespace API_Folhas.Models
{
    public class Funcionario
    {
        //Data Annotations
        public Funcionario() => CriadoEm = DateTime.Now;
        public int FuncionarioId { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public int Salario { get; set; }
        public DateTime Nascimento { get; set; }
        public DateTime CriadoEm { get; set; }
        

        // public override string ToString()
        // {
        //     return base.ToString();
        // }
    }
}