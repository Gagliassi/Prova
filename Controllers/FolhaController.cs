using API_Folhas.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using API.Models;

namespace API_Folhas.Controllers
{
    [ApiController]
    [Route("api/folha")]
    public class FolhaController : ControllerBase
    {

        private readonly DataContext _context;
        public FolhaController(DataContext context) =>
        _context = context;

        [Route("cadastrar")]
        [HttpPost]
        public IActionResult Cadastrar([FromBody] FolhaPagamento folha){
          try
          {
            folha.Funcionario = _context.Funcionarios.Find(folha.FuncionarioId);
            folha.Salariobruto = folha.Valorhora * folha.Quantidadehoras;

            folha.Impostofgts = folha.Salariobruto * 0.08;

        if (folha.Salariobruto <= 1693.72)
        {
            folha.Impostoinss = folha.Salariobruto * 0.08; 

        } else if (folha.Salariobruto <= 2822.9 )
        {
            folha.Impostoinss = folha.Salariobruto*0.09;

        } else if (folha.Salariobruto <= 5645.8)
        {
            folha.Impostoinss = folha.Salariobruto*0.11;
        }
            folha.Impostoinss = 621.03;

        if(folha.Salariobruto <=1903.98)
        {
            folha.Impostorenda = 0;
        } else if (folha.Salariobruto <= 2826.65)
        {
            folha.Impostorenda = (folha.Salariobruto * 0.075) - 142.8;
        } else if(folha.Salariobruto <= 3751.05)
        {
            folha.Impostorenda = (folha.Salariobruto*0.15)-354.8;
        } else if (folha.Salariobruto<=4664.68)
        {
        folha.Impostorenda = (folha.Salariobruto * 0.225)-636.13;
        } folha.Impostorenda = (folha.Salariobruto*0.275)-869.39;  


        folha.Salarioliquido = folha.Salariobruto - folha.Impostorenda -folha.Impostorenda;              

        _context.Folhas.Add(folha);
        _context.SaveChanges();
        return Created("",folha);
    }
    catch 
    {
        return NotFound();
    }
    }

    [HttpGet]
    [Route("listar")]
    public IActionResult Listar() => Ok(_context.Folhas.ToList());

    [Route("buscar/{cpf}")]
        [HttpGet]
        public IActionResult Buscar([FromRoute] string cpf)
        {
            //Expressão lambda
            Funcionario funcionario =
                _context.Funcionarios.FirstOrDefault
            (
                f => f.Cpf.Equals(cpf)
            );
            //IF ternário
            return funcionario != null ? Ok(funcionario) : NotFound();
        }

        [HttpGet]
    [Route("filtrar/{mesAno}")]
    public IActionResult Filtar([FromRoute] int MesAno)
    {
        FolhaPagamento folhaPagamento = _context.Folhas.FirstOrDefault(f=>f.MesAno.Equals(MesAno));

        return folhaPagamento != null ? Ok(folhaPagamento) : NotFound();
    }
}
}

