using Aula10;

Console.WriteLine("Digite três produtos a serem comprados:");

List<string> produtos = new List<string>();

for (int i = 0; i < 3; i++)
{
	produtos.Add(Console.ReadLine());
}

Console.WriteLine("Qual forma de pagamento você deseja? (Pix, Boleto, Cartão)");

string formapagamentodesejada = Console.ReadLine();

if(formapagamentodesejada == FormasPagamentoEnum.Boleto.ToString())
{
	Boleto boleto = new Boleto();
	boleto.EfetuarPagamento();
}
else if(formapagamentodesejada == FormasPagamentoEnum.Pix.ToString())
{
	Pix pix = new Pix();
	pix.EfetuarPagamento();
}
else if (formapagamentodesejada == FormasPagamentoEnum.Cartao.ToString())
{
	new Cartao();
}