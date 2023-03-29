using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosExplorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void adicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQtdAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }
        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);

        }
        public void ListarAlunos()
        {
             Console.WriteLine($"Os alunos do curso de  {Nome} são : ");
            foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine($"{aluno.Nome}");
            }
        }
    }
}