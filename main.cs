using System;
using System.IO;
using System.Collections.Generic;

class MainClass 
{
  public static void Main (string[] args) 
  {
    Console.WriteLine("Cadastro Pessoa baixa renda");
    Console.WriteLine();

    Console.Write("Deseja cadastrar uma nova Pessoa? ");
    string cad = Console.ReadLine().ToUpper();

    //Entrada dos dados pelo usuário
    while(cad == "SIM" || cad == "S")
    {
      Console.Write("Digite o Nome: ");
      string nome = Console.ReadLine();

      Console.Write("Digite o Cargo: ");
      string cargo = Console.ReadLine();

      //Tratamento de exceções
      bool invalido = true;
      int idade = 0;
      double salario = 0;

      do
      {
        try
        {
          Console.Write("Digite a Idade: ");
          idade = int.Parse(Console.ReadLine());
          invalido = false;
        }
        catch (FormatException)
        {
          Console.WriteLine("Dados inválidos favor inserir novamente!");
          invalido = true;
        }
      }
      while (invalido);
            
      Console.Write("Digite a Quantidade de Filhos: ");
      int qtdFilhos = int.Parse(Console.ReadLine());

      do
      {
        try
        {
          Console.Write("Digite o Salário: ");
          salario = double.Parse(Console.ReadLine());
          invalido = false;
        }
        catch (FormatException)
        {
          Console.WriteLine("Dados inválidos favor inserir novamente!");
          invalido = true;
        }
      }
      while (invalido);
      

      //Validação para BENEFICIÁRIOS;
      if(salario <= 1100)
      {        
        //Trabalhando com arquivo .txt
        StreamWriter x;
        string CaminhoNome = "dados.txt";
        x = File.AppendText(CaminhoNome);

        //Salvando dados no arquivo;
        Administrador.AddResponsavel(new Responsavel(nome, idade, cargo, salario, qtdFilhos));
        List <Responsavel>Responsaveis = Administrador.getListaResponsavel();      
        foreach(Responsavel responsavel in  Responsaveis)
        {
          x.WriteLine(responsavel.Imprimir().ToUpper());       
        }

        x.Close();

        if(qtdFilhos > 0)
        {
          //Cadastro de Filho - Herança
          Console.Write("Deseja realizar o cadastro de filho(s) do {0}? ", nome);
          string cad4 = Console.ReadLine().ToUpper();

          //Leitura dos dados;
          while(cad4 == "SIM" || cad4 == "S")
          {
            Console.Write("Digite o Nome: ");
            string nome1 = Console.ReadLine();

            Console.Write("Nome da Escola: : ");
            string nome_sch = Console.ReadLine();

            Console.Write("Digite a Série: ");
            string serie_sch = Console.ReadLine();

            Console.Write("Possui alguma deficiência: ");
            string def_fis = Console.ReadLine();

            //Tratamento de exceções
            bool invalido1 = true;
            int idade1 = 0;
            
            do
            {
              try
              {
                Console.Write("Digite a Idade: ");
                idade = int.Parse(Console.ReadLine());
                invalido = false;
              }
              catch (FormatException)
              {
                Console.WriteLine("Idade inválida, favor inserir novamente!");
                invalido = true;
              }
            }
            while (invalido);       
                
            //Salvando dados do filho
            //Trabalhando com arquivo .txt
            StreamWriter x1;
            string CaminhoNome1 = "dadosfilhos.txt";
            x = File.AppendText(CaminhoNome);

            //Salvando dados no arquivo;
            Administrador.AddFilho(new Filho(nome1, idade, nome_sch, serie_sch, def_fis));
            List <Filho>Filhos = Administrador.getListaFilho();      
            foreach(Filho filho in  Filhos)
            {
              x.WriteLine(filho.Imprimir().ToUpper());       
            }

            x.Close();

            if(qtdFilhos >= 2)
            {
              Console.Write("Possui mais algum filho?  ");
              string cad5 = Console.ReadLine().ToUpper();
              
              if(cad5 == "NAO" || cad5 == "N")
              {
                break;
              } 

            }

          }

        }  


        Console.Write("Deseja cadastrar uma nova Pessoa? ");
        string cad2 = Console.ReadLine().ToUpper();

        if(cad2 == "NAO" || cad2 == "N")
        {
          break;
        }
        
      }

      else if(salario > 1100)
      {
        Console.WriteLine("**********ATENÇÃO*********");
        Console.WriteLine("APENAS CADASTROS DE BAIXA RENDA - SALÁRIO ATÉ R$1100,00");

        Console.WriteLine();

        Console.Write("Deseja cadastrar uma nova Pessoa? ");
        string cad3 = Console.ReadLine().ToUpper();

        if(cad3 == "NAO" || cad3 == "N")
        {
          break;
        }
      }
    }


    
    //Imprimir na tela os benefícios disponíveis;
    Console.WriteLine();
    Console.WriteLine("Deseja verificar o banco de beneficiários? ");
    string resultfinal = Console.ReadLine().ToUpper();
    Console.WriteLine();

    if(resultfinal == "SIM" || resultfinal == "S")
    {
      StreamReader y;

      
      Console.WriteLine();
      Console.WriteLine("DIRETOS Á: \nDesconto pagamento Saneamento Básico 10%\nDesconto pagamento de Energia 5%")
      ;
      Console.WriteLine();
      Console.WriteLine("LISTA DE BENEFICIÁRIOS");
      Console.WriteLine();

      string Caminho = "dados.txt";

      y = File.OpenText(Caminho);

      while(y.EndOfStream != true)
      {
        string linha = y.ReadLine();
        Console.WriteLine(linha);
        
      }    
      y.Close();

      Console.WriteLine();
      Console.Write("********PROGRAMA FINALIZADO*********");
     
    }
    
  }
}