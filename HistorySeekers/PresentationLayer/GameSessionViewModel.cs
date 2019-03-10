using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HistorySeekers.Models;

namespace HistorySeekers.PresentationLayer
{
    public class GameSessionViewModel
    {
        #region ENUMS



        #endregion

        #region FIELDS

        private Player _player;
        private List<string> _messages;
        private DateTime _gameStartTime;

        #endregion

        #region PROPERTIES

        public Player Player
        {
            get { return _player; }
            set { _player = value; }
        }

        public string MessageDisplay
        {
            get { return FormatMessagesForViewer(); }
        }

        #endregion

        #region CONSTRUCTORS

        public GameSessionViewModel()
        {

        }

        public GameSessionViewModel(
            Player player,
            List<string> initialMessages)
        {
            _player = player;
            _messages = initialMessages;
            InitializeView();
        }

        #endregion

        #region METHODS

        /// <summary>
        /// initial setup of the game session view
        /// </summary>
        private void InitializeView()
        {
            _gameStartTime = DateTime.Now;
        }

        
        private string FormatMessagesForViewer()
        {
            List<string> lifoMessages = new List<string>();

            for (int index = 0; index < _messages.Count; index++)
            {
                lifoMessages.Add($" <T:{GameTime().ToString(@"hh\:mm\:ss")}> " + _messages[index]);
            }

            lifoMessages.Reverse();

            return string.Join("\n\n", lifoMessages);
        }

        
        private TimeSpan GameTime()
        {
            return DateTime.Now - _gameStartTime;
        }

        #endregion

        #region EVENTS



        #endregion
    }
}
