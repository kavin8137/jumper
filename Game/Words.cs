using System;
using System.Collections.Generic;

namespace Unit3.Game
{
    public class Words
    {
        TerminalService _terminalService = new TerminalService();
        List<string> _word = new List<string>();
        List<string> _wordList = new List<string>();
        List<string> _words = new List<string>(){"apple","orrange","strawberry"};
        string _answer = "";
        int _value;
        int _length;

        public Words()
        {
            setAnswer();
            getAnswer();
            getWord();
        }

        private void getWord()
        {
            _length = _answer.Length;

            for (int i = 0; i < _length; i++)
            {
                _word.Add("_");
            }
        }

        private void getAnswer()
        {
            char[] wordList = _answer.ToCharArray();
            
            foreach (char i in wordList)
            {
                _wordList.Add(i.ToString());
            }
        }

        private void setAnswer()
        {
            int number = _words.Count();
            Random ranNum = new Random();
            _value = ranNum.Next(number);
            _answer = _words[_value];
        }

        public void showWord()
        {
            foreach(string letter in _word)
            {
                _terminalService.Write(letter + " ");
            }
        }

        public void showAnswer()
        {
            foreach(string letter in _wordList)
            {
                _terminalService.Write(letter + " ");
            }
        }

        public List<string> passAnswer()
        {
            return _wordList;

        }

        public List<string> passWord()
        {
            return _word;
        }

        public int passLength()
        {
            return _length;
        }
    }
}