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

        public decimal CalcularSaldo()
		{
			decimal saldo = 0;
			foreach(var t in _transacoes) 
			{
				saldo += t.Tipo == "Entrada" ? t.Valor : -t.Valor;
			}
			return saldo;
		}
	}
}
