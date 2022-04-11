using System;
using System.Collections.Generic;

namespace ApiAlunos.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public String Matricula { get; set; }
        public String Nome { get; set; }
        public DateTime DtNascimento { get; set; }
        //public List<DiarioPresenca> Presenca { get; set; } = new List<DiarioPresenca>();

        public Aluno()
        {
        }

        public Aluno(int id, string matricula, string nome, DateTime dtNascimento)
        {
            Id = id;
            Matricula = matricula;
            Nome = nome;
            DtNascimento = dtNascimento;
        }
        /*
        public void AddPresenca(DiarioPresenca presenca)
        {
            DiarioPresenca.Add(presenca);
        }

        public void RemovePresenca(DiarioPresenca presenca)
        {
            DiarioPresenca.Add(presenca);
        }*/
    }
}
