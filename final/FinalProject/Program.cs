using System;
using ProtoDB_Project;
using ProtoDB_Project.src;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // See https://aka.ms/new-console-template for more information

        var RED = ConsoleColor.Red;
        var MAGENTA = ConsoleColor.Magenta;
        var CYAN = ConsoleColor.Cyan;
        var GREEN = ConsoleColor.Green;


        Menu newMenu = new Menu();
        BillPayReminder newMainReminder = new BillPayReminder();
        ProgramPlanner newPlanner = new ProgramPlanner();

        WriteColor($"{newMenu.Title}", RED);
        WriteColor("Author: Austin Campbell", CYAN);
        WriteColor("** Type -h, --help, or /? for additional commands **", CYAN);
        WriteColor("** type -quit to quit **", CYAN);
        WriteColor(newMenu.cmds, CYAN);
        bool exitProgram = false;

        while (exitProgram != true)
        {
            WriteColor(">> ", MAGENTA);
            string userInput = Console.ReadLine();

            //This condition is for -help, -h, or /? commands
            if (userInput.Length >= 2 && HelpRequired(userInput))
            {
                //Kind of ridiculous..
                //if inputs length is greaterthan or equal to 3 and HelpRequired with user input as param is true AND
                //user input contains a space, then we will perform the following.
                if (userInput.Length >= 3 && HelpRequired(userInput) && userInput.Contains(" "))
                {
                    string[] splits = userInput.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                    string getCmd = newMenu.Help(splits[1]);
                    WriteColor(getCmd, GREEN);
                    newMenu.ShowSpinner(1);
                }
                else
                {
                    WriteColor(newMenu.cmds, GREEN);
                    newMenu.ShowSpinner(1);
                }
            }
            else
            {
                //Imports every time so you can quickly see what's due or whateva!
                //This idea might bring me to make a legitimate dedicated financial CLI which is what this probably
                //should have been focused on.
                newMainReminder.ImportBillReminder(newMainReminder);
                switch (userInput)
                {
                    case "-quit":
                        exitProgram = true;
                        Environment.Exit(0);
                        break;
                    //create user
                    case "-createuser":
                        Policies newUser = new Policies();
                        string userName = newUser.GetUserName;
                        string password = newUser.GetPassword;
                        int policy = newUser.GetPolicy;
                        break;
                    //create bill to pay
                    case "-createbp":
                        Console.WriteLine("Bill name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Due Date (MM/DD/YYYY: ");
                        string date = Console.ReadLine();
                        Console.WriteLine("Amount: ");
                        double amount = double.Parse(Console.ReadLine());
                        Console.WriteLine("Is bill paid?: ");
                        string paidOrNot = Console.ReadLine().ToLower();

                        CreateBillPay newBill = new CreateBillPay(name, date, amount, paidOrNot);
                        newMainReminder.AddBillToList(newBill);
                        break;
                    //view bills to pay
                    case "-viewbp":
                        newMainReminder.ViewBills(newMainReminder);
                        break;
                    case "-savebp":
                        newMainReminder.ExportBillReminder(newMainReminder);
                        WriteColor("Wrote File to Data", GREEN);
                        break;

                    case "-notes":
                        Notepad newNotepad = new Notepad();
                        newNotepad.Start(newNotepad);
                        break;
                    case "-pd":
                        newPlanner.StartPlanner(newPlanner);
                        break;
                    //ClassDesignerEditor
                    case "-cde":
                        //Makes use of properties in ProgramPlanner
                        if (newPlanner.ProgramName == null)
                        {
                            newMenu.WriteColor("You should use -pd to plan the program first!", RED);
                        }
                        else
                        {
                            newPlanner.RunClassMaker(newPlanner);
                        }
                        break;
                    //FieldsDesigner
                    case "-fd":
                        //Makes use of properties in ProgramPlanner
                        if (newPlanner.IsClasses == null)
                        {
                            newMenu.WriteColor("You should use -cde to create classes first!", RED);
                        }
                        else
                        {
                            newPlanner.RunClassFieldsMaker(newPlanner);
                        }
                        break;
                    case "-exportpd":
                        if (newPlanner.IsClasses == null)
                        {
                            newMenu.WriteColor("You should create a program plan before exporting.", RED);
                        }
                        else
                        {
                            newPlanner.ExportProgram(newPlanner);
                        }
                        break;
                }
            }
        }


        static void Clear()
        {
            Console.Clear();
        }


        static void WriteColor(string msg, ConsoleColor color)
        {
            if (msg.StartsWith(">> "))
            {
                Console.ForegroundColor = color;
                Console.Write($"{msg} ");
            }
            else
            {
                Console.ForegroundColor = color;
                Console.WriteLine(msg);
                Console.ResetColor();
            }
        }


        //Should be used to match first initial part and then help find whatever is after.
        static bool HelpRequired(string param)
        {
            if (param.StartsWith("-h") || param.StartsWith("--help") || param.StartsWith("/?"))
            {
                return true;
            }
            return param == "-h" || param == "--help" || param == "/?";
        }
    }
}