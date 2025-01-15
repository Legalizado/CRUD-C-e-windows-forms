using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace funcionario
{
    internal class ConexaoBanco
    {
        private const string servidor = "localhost";
        private const string bancodedados = "dbFuncionarios";
        private const string usuario = "root";
        private const string senha = "admin";

        static public string conexaoServidor = $"server={servidor}; user id={usuario}; database={bancodedados}; password={senha}";

        
      
    }
}
