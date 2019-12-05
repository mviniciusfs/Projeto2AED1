using System;
using System.Collections.Generic;

static class Administrador

  {
    //Lista - dados da pessoa.
    public static List<Responsavel>Responsaveis = new List<Responsavel>();

    //Adicionar dados inseridos pelo operador do sistema.
    public static void AddResponsavel(Responsavel p1)
    {
      Responsaveis.Add(p1);
    }

    public static List<Responsavel> getListaResponsavel() 
    {
      return Responsaveis;
    }

    //Lista - dados filhos.
    public static List<Filho>Filhos = new List<Filho>();

    //Adicionar dados inseridos pelo operador do sistema.
    public static void AddFilho(Filho p1)
    {
      Filhos.Add(p1);
    }

    public static List<Filho> getListaFilho() 
    {
      return Filhos;
    }            
  }
