using Microsoft.VisualBasic.ApplicationServices;
using Serilog;
using System.Configuration;
using VetTec.Application.NETFrame.Services;
using VetTec.Domain.NETFrame.Entities;
using VetTec.Repository;
using VetTec.Repository.NETFrame.Repositories;
using VetTec.WindowsForms.Views.User;
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

            var connectionString = ConfigurationManager.AppSettings["PetShopDatabase"].ToString();
            UserDB currentUser = new UserDB { email = "admin" };

            var animalRepository = new AnimalRepository(connectionString);
            var animalService = new AnimalService(animalRepository, Log.Logger);
            
            var userRepository = new UserRepository(connectionString);
            var userService = new UserService(userRepository, Log.Logger);


            Application.Run(new LoginUserForm(animalService, userService));
            //Application.Run(new FormList(animalService, currentUser));
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
