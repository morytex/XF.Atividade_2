using System;
using System.Collections.Generic;
using System.Text;
using XF.Atividade_2.Model;

namespace XF.Atividade_2.ViewModel
{
    public class AlunoViewModel
    {
        #region Propriedades
        public String RM { get; set; }
        public String Nome { get; set; }
        public String Email { get; set; }
        #endregion

        public AlunoViewModel(Aluno aluno)
        {
            this.RM = aluno.RM;
            this.Nome = aluno.Nome;
            this.Email = aluno.Email;
        }

        public static Aluno GetAluno()
        {
            return new Aluno()
            {
                Id = Guid.NewGuid(),
                RM = "123456",
                Nome = "Aluno Teste",
                Email = "alunoteste@fiap.com"
            };
        }

        public static List<Aluno> GetAlunos()
        {
            List<Aluno> alunos = new List<Aluno>();
            alunos.Add(new Aluno()
            {
                Id = Guid.NewGuid(),
                RM = "123456",
                Nome = "Aluno Teste 1",
                Email = "alunoteste1@fiap.com"
            });

            alunos.Add(new Aluno()
            {
                Id = Guid.NewGuid(),
                RM = "654321",
                Nome = "Aluno Teste 2",
                Email = "alunoteste2@fiap.com"
            });

            return alunos;
        }
    }
}
