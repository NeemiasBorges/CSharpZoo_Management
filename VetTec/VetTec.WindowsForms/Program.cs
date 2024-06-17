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

            // Ler a string de conex�o do arquivo de configura��o
            var connectionString = ConfigurationManager.ConnectionStrings["PetShopDatabase"].ConnectionString;
            UserDB currentUser = new UserDB { email = "admin" };
            // Cria inst�ncias das classes de reposit�rio e servi�o
            var animalRepository = new AnimalRepository(connectionString);
            var animalService = new AnimalService(animalRepository, Log.Logger);

            // Inicializa o formul�rio principal com o servi�o injetado
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
