using System;
using System.Collections.Generic;

namespace Unit3.Game
{
    /// <summary>

    /// </summary>
    public class Hangman
    {
        List<string> _hangman = new List<string>();
        int _length;
        TerminalService _terminalService = new TerminalService();

        /// <summary>

        /// </summary>
        public Hangman()
        {
            setHangman();
        }

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

        public void setGameHangman()
        {
            _hangman[5] = "   x   ";
        }

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
