using Microsoft.VisualBasic.ApplicationServices;
using Serilog;
using System.Configuration;
using VetTec.Domain.NETFrame.Entities;
using VetTec.Repository;
using VetTec.WinForms;
using Log = Serilog.Log;

public static class Program
{
    [STAThread]
    static void Main()
    {
        var seqUrl = ConfigurationManager.AppSettings["Serilog:SeqUrl"];

        Log.Logger = new LoggerConfiguration()
            .WriteTo.Seq(seqUrl)
            .CreateLogger();

        try
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Ler a string de conexão do arquivo de configuração
            var connectionString = ConfigurationManager.ConnectionStrings["PetShopDatabase"].ConnectionString;
            UserDB currentUser = new UserDB { email = "admin" };
            // Cria instâncias das classes de repositório e serviço
            var animalRepository = new AnimalRepository(connectionString);
            var animalService = new AnimalService(animalRepository, Log.Logger);

            // Inicializa o formulário principal com o serviço injetado
            Application.Run(new FormList(animalService, currentUser));
        }
        catch (Exception ex)
        {
            Log.Fatal(ex, "Application start-up failed");
        }
        finally
        {
            Log.CloseAndFlush();
        }
    }
}
