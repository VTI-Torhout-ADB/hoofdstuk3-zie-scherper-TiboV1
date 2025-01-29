namespace Systeem_informatie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? ProcessorCount;
                ProcessorCount = Environment.ProcessorCount;
            long? WorkingSet;
            WorkingSet = Environment.WorkingSet;
            string? MachineName;
            MachineName = Environment.MachineName;
            string? UserName;
            UserName = Environment.UserName;
            bool? is64OperatingSystem;
            is64OperatingSystem = Environment.Is64BitOperatingSystem;

            long? WorkingSetMB;
            WorkingSetMB = WorkingSet / 1000000;
            Console.WriteLine($"Systeeminformatie voor admin op damsPowahPC:\r\n---------------------------------------------------\r\n    Aantal processors: {ProcessorCount}\r\n    64-bit besturingssysteem: {is64OperatingSystem}\r\n    Huidige geheugengebruik: {WorkingSetMB}\r\n    MachineName: {MachineName}r\n    UserName {UserName}r\n---------------------------------------------------");
        }
    }
}
