using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using web_teste.lib;

namespace web_teste.Models
{
    public class Conteudo
    {
        private string PalavraChave = "THAYNAHCOSTA";
        private ICriptografia _criptografia;
        private IDescriptografia _descriptografia;

        public string Texto { get; set; }
        public string CriptografiaVigenere { get; set; }
        public string DescriptografiaVigenere { get; set; }

        public string CriptografarConteudo(ICriptografia tipoCriptografia)
        {
            _criptografia = tipoCriptografia;
            return _criptografia.Cri_Vigenere(this);
        }

        public void DescriptografarConteudo(IDescriptografia tipoCriptografia)
        {
            _descriptografia = tipoCriptografia;
            _descriptografia.Descri_Vigenere(this);

        }

        public string GetPalavraChave { get { return PalavraChave; } }
    }
}