namespace Unit3.Game
{
    /// <summary>

    ///</summary>
    public class Director
    {
        private int _index;
        private string _guess = "";
        private int _length;
        private List<string> _answer = new List<string>();
        private List<string> _word = new List<string>();
        private Boolean _isWinner;
        private Boolean _isPlay;
        private Words _words = new Words();
        private Hangman _hangman = new Hangman();
        private TerminalService _terminalService = new TerminalService();

        ///<summary>

        ///</summary>
        public Director()
        {
            _index = 0;
            _isWinner = false;
            _isPlay = true;
            _word = _words.passWord();
            _answer = _words.passAnswer();
            _length = _words.passLength();
        }

        /// <summary>

        /// </summary>
        public void StartGame()
        {
            while (_isPlay)
            {
                DoOutPuts();
                GetInPuts();
                DoUpDates();
                showResult();
            }
        }

        /// <summary>

        /// </summary>
        private void GetInPuts()
        {
            _guess = _terminalService.ReadText("Guess a letter [a-z]: ");
            _terminalService.WriteText(" ");
        }

        /// <summary>

        /// </summary>
        private void DoUpDates()
        {
            for (int i = 0; i < _length; i++)
            {
                if (_guess == _answer[i])
                {
                    _word[i] = _guess;
                }
            }
            if (!_answer.Contains(_guess))
            {
                _index += 1;
            }
            else
            {

            }
            
            if (_word.Contains("_"))
            {
                _isPlay = true;
                if (_index == 5)
                {
                    _hangman.setGameHangman();
                    _isPlay = false;
                    _index = 5;
                }
            }
            else
            {
                _isPlay = false;
                _isWinner = true;
            }
        }

        /// <summary>

        /// </summary>
        private void DoOutPuts()
        {
            if (_isPlay)
            {
                _words.showWord();
                _terminalService.WriteText(" \n");
                _hangman.showHangman(_index);
            }
            if (!_isPlay)
            {
                _words.showAnswer();
                _terminalService.WriteText(" \n");
                _hangman.showHangman(_index);
            }
        }

        private void showResult()
        {
            if (_isWinner)
            {
                _words.showAnswer();
                _terminalService.WriteText(" \n");
                _hangman.showHangman(_index);
                _terminalService.WriteText("Congratulations! You guessed the letters! \n");
            }
            else if (_index == 5)
            {
                _words.showWord();
                _terminalService.WriteText(" \n");
                _terminalService.WriteText("The answer is:");
                _words.showAnswer();
                _terminalService.WriteText(" \n");
                _hangman.showHangman(_index);
                _terminalService.WriteText("Unfortunity, you have finished all your chance! \n");
            }
            else
            {

            }
        }
    }
}