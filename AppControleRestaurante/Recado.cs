using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppControleRestaurante
{
    

public class Recado
    {
        public int Id { get; set; }
        public int FuncionarioId { get; set; }
        public string FuncionarioNome { get; set; }
        public int EmpresaId { get; set; }
        public string Assunto { get; set; }
        public string Mensagem { get; set; }
        public DateTime DataEnvio { get; set; }
        public string Status { get; set; }
        public string Resposta { get; set; }
        public DateTime? DataResposta { get; set; }
    }
}

