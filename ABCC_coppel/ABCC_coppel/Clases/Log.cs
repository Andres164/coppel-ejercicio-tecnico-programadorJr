using System;
using System.IO;

namespace Clases
{
    internal static class Log
    {
        private static string dirLogs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ABCC_Coppel\\Logs";
        public static void error(string archivo, string metodo, Exception excepcion)
        {
            Directory.CreateDirectory(Log.dirLogs);
            StreamWriter archivoLogWr;
            using( archivoLogWr = new StreamWriter(Log.dirLogs + "\\" + ABCC_Coppel.Program.archivoLog, true) )
            {
                archivoLogWr.WriteLine($"<Error> [ {DateTime.Now.ToString()} ] {archivo} : {metodo} : {excepcion.StackTrace} Message: {excepcion.Message}");
                archivoLogWr.Flush();
            }
        }
        public static void info(string metodo, string info)
        {
            Directory.CreateDirectory(Log.dirLogs);
            StreamWriter archivoLogWr;
            using (archivoLogWr = new StreamWriter(Log.dirLogs + "\\" + ABCC_Coppel.Program.archivoLog, true))
            {
                archivoLogWr.WriteLine($"<Info> [ {DateTime.Now.ToString()} ] {metodo} Message: {info}");
                archivoLogWr.Flush();
            }
        }
    }
}
