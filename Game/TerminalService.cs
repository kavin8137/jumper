using System;

namespace Unit3.Game
{
    /// <summary>
    /// <para>A service that handles terminal operations.</para>
    /// <para>
    /// The reponsibility of a TerminalService is to provide input and output operations for the terminal.
    /// </para>
    /// </summary>
    public class TerminalService
    {
        /// <summary>
        /// Constructs a new instance of TerminalService
        /// </summary>
        public TerminalService()
        {
        }

        /// <summary>
        /// Gets text input from the terminal. Directs the user with the given prompt.
        /// </summary>
        /// <param name="prompt">The given prompt.</param>
        /// <retruns>Inputted text.</returns>
        public string ReadText(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        /// <summary>
        /// Display the given text on the terminal and have the code run for next line.
        /// </summary>
        /// <param name="prompt">The given prompt.</param>
        /// <returns>Inputted text.</returns>
        public void WriteText(string text)
        {
            Console.WriteLine(text);
        }

        /// <summary>
        /// Display the given text on the terminal.
        /// </summary>
        /// <param name="prompt">The given prompt.</param>
        /// <returns>Inputted text.</returns>
        public void Write(string text)
        {
            Console.Write(text);
        }
    }
}