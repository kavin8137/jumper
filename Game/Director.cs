namespace Unit3.Game
{
    /// <summary>
    /// <para>A person who directs the game.</para>
    /// <para>
    /// The responsibility of a Director is to control the sequence of play.
    /// </para>
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
        /// Constructs a new instance of Director.
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
        /// Starts the game by running the main game loop.
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
        /// Get input from the user for guessing the letter.
        /// </summary>
        private void GetInPuts()
        {
            _guess = _terminalService.ReadText("Guess a letter [a-z]: ");
            _terminalService.WriteText(" ");
        }

        /// <summary>
        /// Compare the input from the unser with the answer.
        /// If the guessed letter is one of the letter in answer, the list will adjust to the word accordingly.
        /// If the guessed letter is not one of the letter in answer, the hangman list will cancel by one index.
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
        /// Display both the hint and hangman to the user.
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

        /// <summary>
        /// If one of the end game condition is met, the game will ends by showing the final answer and greetings.
        /// </summary>
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
        }
    }
}