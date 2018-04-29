using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using web_teste.Models;

namespace web_teste.lib
{
    public class Descriptografar : IDescriptografia
    {

        public void Descri_Vigenere(Conteudo conteudo)
        {
            var mensagem = "";
            
            for (int i = 0; i < conteudo.CriptografiaVigenere.Length; i++)
            {
                char c = char.ToUpper(conteudo.CriptografiaVigenere[i]);
                if (c < 'A' || c > 'Z')
                {
                    continue;
                }
                char cha = char.ToUpper(conteudo.GetPalavraChave[i % conteudo.GetPalavraChave.Length]);
                mensagem += (char)((26 - (cha % 65 - c % 65)) % 26 + 65);
            }

            conteudo.DescriptografiaVigenere = mensagem;
        }
    }
}