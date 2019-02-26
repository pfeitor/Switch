using System;
using Switch.Infra.Data.Context;
using Switch.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;
using Switch.Infra.CrossCutting.Logging;

namespace SwitchAPP
{
    class Program
    {
        static void Main(string[] args)
        {

            var usuario = new Usuario()
            {
                Nome = "Paulo",
                SobreNome = "Feitor",
                Senha = "123",
                Email = "paulo@email.com",
                DataNascimento = DateTime.Now,
                Sexo = Switch.Domain.Enums.SexoEnum.Masculino,
                UrlFoto = @"c:\temp"
            };

            var optionsBuilder = new DbContextOptionsBuilder<SwitchContext>();

            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseMySql("Server=localhost;userid=root;password=mysql;database=SwitchDB;",m => m.MigrationsAssembly("Switch.Infra.Data").MaxBatchSize(1000));
        

            try
            {
                using(var dbcontext = new SwitchContext(optionsBuilder.Options))
                {
                    dbcontext.GetService<ILoggerFactory>().AddProvider(new Logger());
                    dbcontext.Usuarios.Add(usuario);
                    dbcontext.SaveChanges();
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            Console.WriteLine("OK!");
            Console.ReadKey();
            
            
        }
    }
}
