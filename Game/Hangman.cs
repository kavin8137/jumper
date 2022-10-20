using System;
using System.Collections.Generic;

namespace Unit3.Game
{
    /// <summary>
    /// <para>The portion of displaying hangman to the user. </para>
    /// <para>
    /// The responsibility of Hangman is to keep track of the hangman each time when the user input a guess.
    /// </para>
    /// </summary>
    public class Hangman
    {
        List<string> _hangman = new List<string>();
        int _length;
        TerminalService _terminalService = new TerminalService();

        /// <summary>
        /// Constructs a new instance of Hangman.
        /// </summary>
        public Hangman()
        {
            setHangman();
        }

        /// <summary>
        /// Elements of hangman has been added to the list.
        /// </summary>
        public void setHangman()
        {
            _hangman.Add(" -----");
            _hangman.Add(@"/     \");
            _hangman.Add("-------");
            _hangman.Add(@" \   /  ");
            _hangman.Add(@"  \ /   ");
            _hangman.Add("   o   ");
            _hangman.Add(@"  /|\  ");
            _hangman.Add("   |  ");
            _hangman.Add(@"  / \  ");
            _hangman.Add(" ");
            _hangman.Add("^^^^^^^^");
        }

        /// <summary>
        /// When the end game condition is med, the hangman head will be changed to an "x".
        /// </summary>
        public void setGameHangman()
        {
            _hangman[5] = "   x   ";
        }

        /// <summary>
        /// Print the hangman to the user.
        /// </summary>
        public void showHangman(int index)
        {
            _length = _hangman.Count();
            for (int i = index; i < _length; i++)
            {
                _terminalService.WriteText(_hangman[i]);
            }
        }
    }
}
