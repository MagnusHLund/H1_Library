namespace H1_Library
{
    internal class Program
    {
        /// <summary>
        /// Calls the controller method, and gets out of static
        /// </summary>
        static void Main()
        {
            Controller.Controller controller = new Controller.Controller();
            controller.Start();
        }
    }
}