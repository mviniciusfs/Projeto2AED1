using System;

class Pessoa 

  //Classe com atributos e método para imprimir dados no arquivo.
  {
    public string Nome;
    public int Idade;

    public Pessoa (string n, int i)
    {
      Nome = n;
      Idade = i;
    }


          
    public string Imprimir()
    {
      string dados = Nome +"||"+ Idade;

      return dados;
    }
        
  }
