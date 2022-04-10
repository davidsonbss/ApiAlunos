using System;

namespace ApiAlunos.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public String Matricula { get; set; }
        public String Nome { get; set; }
        public DateTime DtNascimento { get; set; }

    }
}
