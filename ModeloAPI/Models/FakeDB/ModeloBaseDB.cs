using ModeloAPI.Models.Poco;
using System;
using System.Collections.Generic;


namespace ModeloAPI.Models.FakeDB
{
    /// <summary>
    /// 
    /// </summary>
    public static class ModeloBaseDB
    {
        private static List<ModeloBasePoco> listModelBase;

        /// <summary>
        /// 
        /// </summary>
        public static List<ModeloBasePoco> ListModelBase
        {
            get
            {
                if (listModelBase == null)
                {
                    listModelBase = new List<ModeloBasePoco>() 
                    { 
                        new ModeloBasePoco() { Codigo = 1, Nome = "abc", Endereco = "abc", Telefone = "123" },
                        new ModeloBasePoco() { Codigo = 2, Nome = "abc", Endereco = "abc", Telefone = "123" },
                        new ModeloBasePoco() { Codigo = 3, Nome = "abc", Endereco = "abc", Telefone = "123" },
                        new ModeloBasePoco() { Codigo = 4, Nome = "abc", Endereco = "abc", Telefone = "123" },
                        new ModeloBasePoco() { Codigo = 5, Nome = "abc", Endereco = "abc", Telefone = "123" },
                        new ModeloBasePoco() { Codigo = 6, Nome = "abc", Endereco = "abc", Telefone = "123" },
                        new ModeloBasePoco() { Codigo = 7, Nome = "abc", Endereco = "abc", Telefone = "123" },
                        new ModeloBasePoco() { Codigo = 8, Nome = "abc", Endereco = "abc", Telefone = "123" },
                        new ModeloBasePoco() { Codigo = 9, Nome = "abc", Endereco = "abc", Telefone = "123" },
                        new ModeloBasePoco() { Codigo = 10, Nome = "abc", Endereco = "abc", Telefone = "123" },
                        new ModeloBasePoco() { Codigo = 11, Nome = "abc", Endereco = "abc", Telefone = "123" },
                        new ModeloBasePoco() { Codigo = 12, Nome = "abc", Endereco = "abc", Telefone = "123" },
                        new ModeloBasePoco() { Codigo = 13, Nome = "abc", Endereco = "abc", Telefone = "123" },
                        new ModeloBasePoco() { Codigo = 14, Nome = "abc", Endereco = "abc", Telefone = "123" },
                        new ModeloBasePoco() { Codigo = 15, Nome = "abc", Endereco = "abc", Telefone = "123" },
                        new ModeloBasePoco() { Codigo = 16, Nome = "abc", Endereco = "abc", Telefone = "123" },
                        new ModeloBasePoco() { Codigo = 17, Nome = "abc", Endereco = "abc", Telefone = "123" },
                        new ModeloBasePoco() { Codigo = 18, Nome = "abc", Endereco = "abc", Telefone = "123" },
                        new ModeloBasePoco() { Codigo = 19, Nome = "abc", Endereco = "abc", Telefone = "123" },
                        new ModeloBasePoco() { Codigo = 20, Nome = "abc", Endereco = "abc", Telefone = "123" }
                    };
                }
                return listModelBase;
            }
        }
    }    
}