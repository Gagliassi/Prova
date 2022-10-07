using API_Folhas.Models;

namespace API.Models
{
    public class FolhaPagamento
    {
        public int Id { get; set; }
        public double Valorhora { get; set; }
        public double Quantidadehoras { get; set; }
        public double Salariobruto { get; set;} 
        public double Impostorenda { get; set; }
        public double Impostoinss { get; set; }
        public double Impostofgts { get ; set; }
        public double Salarioliquido { get; set;}
        public int MesAno { get; set; }
        public Funcionario Funcionario { get; set; }
        public int FuncionarioId { get; set; }
    }
}