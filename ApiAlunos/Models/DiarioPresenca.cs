using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAlunos.Models
{
    public class DiarioPresenca
    {
        public Turma Id_Turma { get; set; }
        public Aluno Id_Aluno { get; set; }
        public DateTime DtChamada { get; set; }
        public bool StPresenca { get; set; }

        public DiarioPresenca()
        {
        }

        public DiarioPresenca(Turma id_Turma, Aluno id_Aluno, DateTime dtChamada, bool stPresenca)
        {
            Id_Turma = id_Turma;
            Id_Aluno = id_Aluno;
            DtChamada = dtChamada;
            StPresenca = stPresenca;
        }
    }
}
