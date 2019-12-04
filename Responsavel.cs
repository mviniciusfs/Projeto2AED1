using System;

class Resposavel : Pessoa 

  //Classe com atributos e método para imprimir dados no arquivo.
  {
    public string Cargo;
    public double Salario;
    public int QtdFilhos;

    public Responsavel (string n, int i, string c, double s, int q) : base (n, i)
    {
      base.Nome = n;
      base.Idade = i;
      this.Cargo = c;
      this.Salario = s;
      this.QtdFilhos = q;
      
    }

    public string Imprimir()
    {
      string dados = base.Imprimir() +"||"+ Cargo +"||R$"+ Salario +",00||"+ QtdFilhos + " filho(s)";

      return dados;
    }    
  }
