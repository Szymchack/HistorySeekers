using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace HistorySeekers.Models
{
   public class Map
    {
        
        #region ENUMS


        #endregion

        #region FIELDS

        private int _id; 
        private string _name;
        private string _description;
        private bool _accessible;
        private int _requiredExperiencePoints;
        private int _modifiyExperiencePoints;
        private int _modifyHealth;
        private int _modifyLives;
        private string _message;

        private ObservableCollection<Location> _locations;
        private Location _location;


        public Location Location
        {
            get { return _location; }
            set { _location = value; }
        }


        public ObservableCollection<Location> Locations
        {
            get { return _locations; }
            set { _locations = value; }
        }

        public ObservableCollection<Location> AccessibleLocations()
        {
            ObservableCollection<Location> accessibleLocation = new ObservableCollection<Location>();

                foreach (var location in _locations)
            {
                if (location.Accessible==true)
                {
                    accessibleLocation.Add(location);
                }

            }
            return accessibleLocation;
        }


        #endregion


        #region PROPERTIES

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public bool Accessible
        {
            get { return _accessible; }
            set { _accessible = value; }
        }

        public int ModifiyExperiencePoints
        {
            get { return _modifiyExperiencePoints; }
            set { _modifiyExperiencePoints = value; }
        }

        public int RequiredExperiencePoints
        {
            get { return _requiredExperiencePoints; }
            set { _requiredExperiencePoints = value; }
        }

        public int ModifyHealth
        {
            get { return _modifyHealth; }
            set { _modifyHealth = value; }
        }

        public int ModifyLives
        {
            get { return _modifyLives; }
            set { _modifyLives = value; }
        }

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        #endregion


        #region CONSTRUCTORS



        #endregion


        #region METHODS

        public void Move(Location location)
        {
            _location = Location;
        }

        public bool IsAccessibleByExperiencePoints(int playerExperiencePoints)
        {
            return playerExperiencePoints >= _requiredExperiencePoints ? true : false;
        }

        internal void MoveSouth()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}

