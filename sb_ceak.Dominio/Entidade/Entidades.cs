using System.Collections.Generic;
using System.Linq;

namespace sb_ceak.Dominio.Entidade
{
    public abstract class Entidades
    {
        public List<string> _mensgensValidacao { get; set; }
        private List<string> mensagemValidacao 
        { 
            get { return _mensgensValidacao ?? (_mensgensValidacao = new List<string>()); }
        }
        protected void LimparMensagemValidacao()
        {
            mensagemValidacao.Clear();
        }

        protected void AdicionarMensagemValidacao(string mensagem)
        {
            mensagemValidacao.Add(mensagem);
        }

        public abstract void Validate();

        protected bool EhValido
        {
            get { return !mensagemValidacao.Any(); }
        }
}
