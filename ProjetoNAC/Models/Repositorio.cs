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
        private List<Contato> contatos;

        private Repositorio()
        {
            investidores = new List<Investidor>();
            contatos = new List<Contato>();
        }

        public static Repositorio Instance()
        {
            if(_repositorio == null){
                _repositorio = new Repositorio();
            }
            return _repositorio;
        }
        //Investidor CRUD
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
        //Contato
        public void IncluirContato(Contato cont)
        {
            contatos.Add(cont);
        }
        
        public IEnumerable<Contato> ListarContatos()
        {
            return contatos;
        }

        public Contato ListarContato(int id)
        {
            return contatos.Where(i => i.Id == id).First();
        }
        public void ExcluirContato(int id)
        {
            contatos.Remove(ListarContato(id));
        }

        public void AlterarContato(Contato cont)
        {
            contatos.Where(i => i.Id == cont.Id)
                .ToList()
                .ForEach(s =>
                {
                    s.Nome = cont.Nome;
                    s.Email = cont.Email;
                    s.Mensagem = cont.Mensagem;
                });
        }
    }
}