using System;

/*
1- Criar um programa que leia dois números inteiros, e que solicite ao usuário qual a operação 
deseja realizar entre esses números. Caso o usuário digitar o caractere “*” será realizada uma multiplicação, 
caso seja digitado o caractere “/” será realizada uma divisão, caso seja digitado o caractere “+” 
será realizado uma adição, e caso seja digitado o caractere “–” será realizada uma subtração.

2- O cardápio de uma casa de lanches é dado pela tabela abaixo:
Código Produto Preço Unitário (R$)
---------------------------------
100  Cachorro quente   R$ 1,70
101   Bauru Simples    R$ 2,30
102   Bauru com ovo    R$ 2,60
103   Hamburguer       R$ 2,40
104   Cheeseburguer    R$ 2,50
105   Refrigerante     R$ 1,00
----------------------------------
Escreva um algoritmo que leia o código do item adquirido pelo consumidor e a
quantidade, calculando e mostrando o valor a pagar. Não será necessário exibir o produto
e o valor, somente o valor final

3- Crie um programa que funcione para uma votação eleitoral. Existem três candidatos:
33 - José Couve
25 - Joana Bravo
10 - Roberto Nove
0 - Voto branco
4 - Voto nulo

Deseja-se saber:
- O candidato vencedor;
- O total de votos em branco;
- O total de votos nulos;
*/

class MainClass {
	public static double Operacao (char op, int n1, int n2) {
		switch (op){
			case '*':
				return n1*n2;
			case '/':
				return n1/n2;
			case '+':
				return n1+n2;
			case '-':
				return n1-n2;
			default:
				return -1;
		}
	}

	public static double ValorFinal (int codigo, int qtd) {
		switch (codigo) {
			case 100:
				return 1.7*qtd;
			case 101:
				return 2.3*qtd;
			case 102:
				return 2.6*qtd;
			case 103:
				return 2.4*qtd;
			case 104:
				return 2.5*qtd;
			case 105:
				return 1.0*qtd;
			default:
				return -1;
		}
	}

  public static void Main () {
		//ex01
    int n1, n2;
		char op;
		Console.WriteLine ("* EXERCÍCIO 1 *");
		Console.Write ("Informe o primeiro número >> ");
		n1 = int.Parse(Console.ReadLine());
		Console.Write ("Informe o segundo número >> ");
		n2 = int.Parse(Console.ReadLine());
		Console.Write ("Informe a operação desejada (* / + -) >> ");
		op = char.Parse(Console.ReadLine());
		Console.Write ("O resultado da operação foi: {0}", Operacao(op, n1, n2));

		//ex02
		int codigo, qtd;
		double total;
		Console.WriteLine ("* EXERCÍCIO 2 *\n\nCódigo Produto Preço Unitário (R$)\n---------------------------------\n100   Cachorro quente  R$ 1,70\n101   Bauru Simples    R$ 2,30\n102   Bauru com ovo    R$ 2,60\n103   Hamburguer       R$ 2,40\n104   Cheeseburguer    R$ 2,50\n105   Refrigerante     R$ 1,00\n----------------------------------");
		Console.Write ("Informe o código do produto desejado >> ");
		codigo = int.Parse(Console.ReadLine());
		Console.Write ("Informe a quantidade desejada >> ");
		qtd = int.Parse(Console.ReadLine());
		Console.Write ("O seu pedido dará um total de >> R$ {0}", ValorFinal(codigo, qtd));
  }
}