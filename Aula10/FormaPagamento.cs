using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10
{
	public class FormaPagamento
	{
		public virtual void EfetuarPagamento()
		{
			Console.WriteLine("Pagamento efetuado");
		}
	}

	public class Boleto : FormaPagamento
	{
		public override void EfetuarPagamento()
		{
			Console.WriteLine("Pagamento efetuado por boleto");
		}
	}

	public class Pix : FormaPagamento
	{
		public override void EfetuarPagamento()
		{
			Console.WriteLine("Pagamento efetuado por pix");
		}
	}

	public class Cartao : FormaPagamento
	{

		public Cartao()
		{
			EfetuarPagamento();
		}

		public override void EfetuarPagamento()
		{
			Console.WriteLine("Pagamento efetuado por cartão de crédito");
		}
	}
}
