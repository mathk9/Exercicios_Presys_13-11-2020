using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Criptografia_Exemplo
{
     public class Controle
    {
         public bool existe;
         public string mensagem = "";

         public bool acessar(string login, string senha)
         {
             LoginComandos loginComandos = new LoginComandos();
             existe = loginComandos.VerificarLogin(login, senha);
             if (!loginComandos.mensagem.Equals(""))
             {
                 this.mensagem = loginComandos.mensagem;
             }
             return existe;
         }

         public string cadastrar(string email, string senha, string confirmar)
         {
             LoginComandos loginComandos = new LoginComandos();
             this.mensagem = loginComandos.Cadastrar(email, senha, confirmar);
             if (loginComandos.existe)
             {
                 this.existe = true;
             }
             return mensagem;
         }

         public void Descadastrar(string email, string senha)
         {
             LoginComandos loginComandos = new LoginComandos();
             existe = loginComandos.VerificarLogin(email, senha);
            
             if (loginComandos.existe)
             {
                 this.existe = true;
                 loginComandos.Deleta(email, senha);
             }
             
         }

         public string alterar(string email, string senha, string confirmar)
         {
             LoginComandos loginComandos = new LoginComandos();
             this.mensagem = loginComandos.MudarSenha(email, senha, confirmar);
             if (loginComandos.existe)
             {
                 this.existe = true;
             }
             return mensagem;
         }
    }
}
