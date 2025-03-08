using System;
using GestorFinanceiro.Models;
using System.Collections.Generic;

namespace GestorFinanceiro.Repositorios
{
	public class RepositorioTransacoes
	{
		private List<Transacao> _transacoes = new();
		private int _nextId =1;

		public void AddTransition(Transacao transacao)
		{
			transacao.Id = _nextId++;
			_transacoes.Add(transacao);
		}

		public List<Transacao> ListTransitions()
		{
			return _transacoes;
		}

        public void CalcularSaldo(out decimal entradas, out decimal saidas)
		{
			entradas = 0;
			saidas = 0;

			foreach (var t in _transacoes)
			{
				if (t.Tipo == "Entrada")
				{
					entradas += t.Valor; //SOMA OS VALORES DAS ENTRADAS
				}
				else
				{
					saidas += t.Valor; //SOMA OS VALORES DAS SAÍDAS
				}
			}
		}
	}
}
