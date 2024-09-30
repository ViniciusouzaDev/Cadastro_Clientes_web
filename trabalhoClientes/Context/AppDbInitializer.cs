using System.ComponentModel.DataAnnotations;
using trabalhoClientes.Models;

namespace trabalhoClientes.Context
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var Context = serviceScope.ServiceProvider.GetService<AppCont>();
                Context.Database.EnsureCreated();

                if (!Context.Clientes.Any())
                {
                    Context.Clientes.AddRange(new List<CadCliente>()
                            {
                                new CadCliente()
                                {
                                    Nome = "Vinicius",
                                    Email = "pietro430@uorak.com",
                                    Telefone = "28 98722-9525",
                                    cep = "15412-120",
                                    rua = "25 de março",
                                    Numero = 14,
                                    bairro = "Limoeiro"
                                   
                                },

                                 new CadCliente()
                                {
                                    Nome = "Rafaella",
                                    Email = "b46v2jvzl5@expressletter.net",
                                    Telefone = "66 97122-6111",
                                    cep = "15412-130",
                                    rua = "Avenida Paulista",
                                    Numero = 15,
                                    bairro = "Casquinha de bala"

                                },

                                   new CadCliente()
                                {
                                    Nome = "Ricardo",
                                    Email = "l285s97lpq@expressletter.net",
                                    Telefone = "15 99248-2603",
                                    cep = "15412-111",
                                    rua = "Garimpeiro novo",
                                    Numero = 16,
                                    bairro = "Garimpo"
                                },

                                     new CadCliente()
                                {
                                    Nome = "Ricardo",
                                    Email = "elcira2640@uorak.com",
                                    Telefone = "71 99515-1145",
                                    cep = "15412-074",
                                    rua = "lua de saturno",
                                    Numero = 17,
                                    bairro = "Recreio das luas"
                                },

                                     new CadCliente()
                                {
                                    Nome = "Ricardo",
                                    Email = "teresia9580@uorak.com",
                                    Telefone = "88 99442-2786",
                                    cep = "15412-114",
                                    rua = "Antonini Machado",
                                    Numero = 18,
                                    bairro = "Nova Acacia"
                                },
                            });
                    Context.SaveChanges();
                }
            }
        }
    }
}
