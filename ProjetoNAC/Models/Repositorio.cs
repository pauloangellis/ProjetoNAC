using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoNAC.Models
{
    public class Repositorio
    {
        private static Repositorio _repositorio;

        private List<Investidor> investidores;

        private Repositorio()
        {
            investidores = new List<Investidor>();
        }

        public static Repositorio Instance()
        {
            if(_repositorio == null){
                _repositorio = new Repositorio();
            }
            return _repositorio;
        }

        public void IncluirInvestidor(Investidor invest)
        {
            investidores.Add(invest);
        }

        public IEnumerable<Investidor> ListarInvestidores()
        {
            return investidores;
        }

        public Investidor ListarInvestidor(int id)
        {
            return investidores.Where(i => i.Id == id).First();
        }

        public void ExcluirInvestidor(int id)
        {
            investidores.Remove(ListarInvestidor(id));
        }

        public void AlterarInvestidor(Investidor invest)
        {
            investidores.Where(i => i.Id == invest.Id)
                .ToList()
                .ForEach(s =>
                {
                    s.Nome = invest.Nome;
                    s.Email = invest.Email;
                    s.Telefone = invest.Telefone;
                    s.Genero = invest.Genero;
                    s.Endereco = invest.Endereco;
                    s.Cidade = invest.Cidade;
                    s.Estado = invest.Estado;
                });
        }
    }
}