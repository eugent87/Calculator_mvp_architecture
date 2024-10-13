using Calculator;

namespace Calculator
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new Calculator_Model());


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Создание экземпляра представления
            Calculator_Model view = new Calculator_Model();
            Calculator_Mod model = new Calculator_Mod();
            Calculator_Presenter presenter = new Calculator_Presenter(view, model);

            Application.Run(view);
        }
    }
}

//Application.EnableVisualStyles();
//Application.SetCompatibleTextRenderingDefault(false);

//// Создание экземпляра представления
//Calculator_Model view = new Calculator_Model();
//Calculator_Mod model = new Calculator_Mod();
//Calculator_Presenter presenter = new Calculator_Presenter(view, model);

//Application.Run(view);