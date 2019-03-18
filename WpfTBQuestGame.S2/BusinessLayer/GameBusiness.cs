using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HistorySeekers.Models;
using HistorySeekers.DataLayer;
using HistorySeekers.PresentationLayer;

namespace HistorySeekers.BusinessLayer
{
    bool
    
    public class GameBusiness
    {
        GameSessionViewModel _gameSessionViewModel;
        Player _player;
        List<string> _messages;
      

        public GameBusiness()
        {
            InitializeDataSet();
            InstantiateAndShowView();
        }

        private void InitializeDataSet()
        {
            _player = GameData.PlayerData();
            _messages = GameData.InitialMessages();
        }
        

        
        private void InstantiateAndShowView()
        {

            _gameSessionViewModel = new GameSessionViewModel (
                _player,
                GameData.InitialMessages(),
                GameData.GameMap(),
                GameData.InitialGameMapLocation()
            ); 
               

               
            GameSessionView gameSessionView = new GameSessionView(_gameSessionViewModel);

            gameSessionView.DataContext = _gameSessionViewModel;

            gameSessionView.Show();

            
        }
    }
}
