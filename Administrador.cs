using System;
using System.Collections.Generic;

static class Administrador

  {
    //Lista - dados da pessoa.
    public static List<Responsavel>Responsaveis = new List<Pessoa>();

    //Adicionar dados inseridos pelo operador do sistema.
    public static void AddResponsavel(Responsavel p1)
    {
      Responsaveis.Add(p1);
    }

    public static List<Responsavel> getListaResponsavel() 
    {
      return Responsaveis;
    }

        //Lista - dados da pessoa.
    public static List<Responsavel>Responsaveis = new List<Pessoa>();

    //Adicionar dados inseridos pelo operador do sistema.
    public static void AddResponsavel(Responsavel p1)
    {
      Responsaveis.Add(p1);
    }

    public static List<Responsavel> getListaResponsavel() 
    {
      return Responsaveis;
    }            
  }
