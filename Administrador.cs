using System;
using System.Collections.Generic;

static class Administrador

  {
    //Lista - dados da pessoa.
    public static List<Pessoa>Pessoas = new List<Pessoa>();

    //Adicionar dados inseridos pelo operador do sistema.
    public static void AddPessoa(Pessoa p1)
    {
      Pessoas.Add(p1);
    }

    public static List<Pessoa> getListaPessoa() 
    {
      return Pessoas;
    }           
  }