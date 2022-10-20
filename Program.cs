using Unit3.Game;

namespace Unit3 // Note: actual namespace depends on the project name.
{
    /// <summary>
    /// The program's entry point.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Starts the program using the given arguments.
        /// </summary>
        /// <param name="args">The given arguments.</param>
        static void Main(string[] args)
        {
            Director director = new Director();
            director.StartGame();
        }
    }
}