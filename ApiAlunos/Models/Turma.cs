using ApiAlunos.Models.Enums;
using System;

namespace ApiAlunos.Models
{
    public class Turma
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public CodeTurno Turno { get; set; }

        public Turma()
        {
        }
        public Turma(int id, string nome, CodeTurno turno)
        {
            Id = id;
            Nome = nome;
            Turno = turno;
        }
    }
}
