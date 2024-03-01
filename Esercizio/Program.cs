using log4net;
using log4net.Config;
using System.Reflection;




var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));

var _log4net = log4net.LogManager.GetLogger(typeof(Program));

int? zero= 0;
try
{
    _log4net.Info("Start program");

    Console.WriteLine("Inserisci il primo numero:");
    int a= int.Parse(Console.ReadLine());  
    Console.WriteLine(a);
    Console.WriteLine("Inserisci il secondo numero:");
    string b = Console.ReadLine();
    Console.WriteLine(b);
    var c = a / zero;

    throw new DivideByZeroException();
    throw new FormatException();
    throw new Exception(); 
}
catch (DivideByZeroException VariabileDiErrore)
{
    _log4net.Error("errore 1:" + VariabileDiErrore);
}
catch (FormatException VariabileDiErrore)
{
    _log4net.Error("errore 2:" + VariabileDiErrore);
}
catch (Exception VariabileDiErrore)
{
    _log4net.Error("errore 3:" + VariabileDiErrore);
}

finally
{
    _log4net.Error("tutte le eccezioni gestite");
}


