using System;

namespace PadraoProjetoObserver
{
    class Program
    {
        static void Main(string[] args)
        {

            EditoraConcreta editora = new EditoraConcreta();
            // Editora ja inicia com valor padrão igual a false

            AssinanteConcreto assinante1 = new AssinanteConcreto(editora);
            AssinanteConcreto assinante2 = new AssinanteConcreto(editora);
            AssinanteConcreto assinante3 = new AssinanteConcreto(editora);
            AssinanteConcreto assinante4 = new AssinanteConcreto(editora);
            AssinanteConcreto assinante5 = new AssinanteConcreto(editora);

            // Já passando a editora como parametro

            editora.alterarEdicao();
            // Nesse momento é chamado o método atualizar
            // das instâncias assinante1 e assinante2, resultadao:
            // [Aviso] A Editora mudou seu estado para: true (5 x) 

            editora.alterarEdicao();
            //[Aviso] A Editora mudou seu estado para: false (5 x)

            // Obs: temos 5 saídas porque temos 5 assinantes
            Console.ReadKey();
        }
    }
}
