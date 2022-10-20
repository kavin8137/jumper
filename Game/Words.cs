using System;
using System.Collections.Generic;

namespace Unit3.Game
{
    /// <summary>
    /// The responsibility of Words is to track the answer and the guessed letter from the user.
    /// </summary>
    public class Words
    {
        TerminalService _terminalService = new TerminalService();
        List<string> _word = new List<string>();
        List<string> _wordList = new List<string>();
        List<string> _words = new List<string>(){"apple","orrange","strawberry"};
        string _answer = "";
        int _value;
        int _length;

        /// <summary>
        /// Constructs an instance of Words.
        /// </summary>
        public Words()
        {
            setAnswer();
            getAnswer();
            getWord();
        }

        /// <summary>
        /// Set the hint list to the number of letter from _answer.
        /// </summary>
        private void getWord()
        {
            _length = _answer.Length;

            for (int i = 0; i < _length; i++)
            {
                _word.Add("_");
            }
        }

        /// <summary>
        /// Set the answer list from the _answer variable.
        /// </summary>
        private void getAnswer()
        {
            char[] wordList = _answer.ToCharArray();
            
            foreach (char i in wordList)
            {
                _wordList.Add(i.ToString());
            }
        }

        /// <summary>
        /// Set the answer from one of the word in the _words list.
        /// </summary>
        private void setAnswer()
        {
            int number = _words.Count();
            Random ranNum = new Random();
            _value = ranNum.Next(number);
            _answer = _words[_value];
        }

        /// <summary>
        /// Pressenting the hint to the user when it is called.
        /// </summary>
        public void showWord()
        {
            foreach(string letter in _word)
            {
                _terminalService.Write(letter + " ");
            }
        }

        /// <summary>
        /// Presenting the answer to the user when it is called.
        /// </summary>
        public void showAnswer()
        {
            foreach(string letter in _wordList)
            {
                _terminalService.Write(letter + " ");
            }
        }


        /// <summary>
        /// Passing the _wordList variable when it is called.
        /// </summary>
        public List<string> passAnswer()
        {
            return _wordList;

        }

        /// <summary>
        /// Passing the _word variable when it is called.
        /// </summary>
        public List<string> passWord()
        {
            return _word;
        }

        /// <summary>
        /// Passing the _length variable when it is called. 
        /// </summary>
        public int passLength()
        {
            return _length;
        }
    }
}