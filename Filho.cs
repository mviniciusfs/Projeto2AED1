using System;

class Filho : Pessoa 

  //Classe com atributos e método para imprimir dados no arquivo.
  {
    public string Escola;
    public string Serie;
    public string Def_Fisica;

    public Filho (string n, int i, string e, string s, string d) : base (n, i)
    {
      base.Nome = n;
      base.Idade = i;
      this.Escola = c;
      this.Serie = s;
      this.Def_Fisica = d;
      
    }

    public string Imprimir()
    {
      string dados = base.Imprimir() +"||"+ Escola +"||"+"Ano escolar: " Serie +"||"+"Possui Def. Física: " Def_Fisica +;

      return dados;
    }    
  }