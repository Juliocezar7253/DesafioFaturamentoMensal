/* 
Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:

SP – R$67.836,43
RJ – R$36.678,66
MG – R$29.229,88
ES – R$27.165,48
Outros – R$19.849,53

Escreva um programa na linguagem que desejar onde calcule o percentual de representação 
que cada estado teve dentro do valor total mensal da distribuidora.
*/

using System;

namespace Percentual {
    class Percentual {

      static List<Faturamento> faturamento = new List<Faturamento>();

      static void Definition() {
        faturamento.Add(new Faturamento(67836.43, "SP"));
        faturamento.Add(new Faturamento(36678.66, "RJ"));
        faturamento.Add(new Faturamento(29229.88, "MG"));
        faturamento.Add(new Faturamento(27165.48, "ES"));
        faturamento.Add(new Faturamento(19849.53, "OUTROS"));
      }

      static void Main(string[] args) => calc();

      static void calc() { 
        Definition();
        var total = 0.0;

        faturamento.ForEach(f => total+= f.Valor);

        foreach (var aux in faturamento) { 
            var participacao = (aux.Valor/total) * 100;

            Console.WriteLine($"O percentual de {aux.Estado} no valor total R$ {total} é: {participacao:f2}%");
        }
      }

    }

    public class Faturamento {
        public string Estado { get; set; }
        public double Valor { get; set; }

        public Faturamento(double valor, string estado) {
            this.Valor = valor;
            this.Estado = estado;
        }

    }
}