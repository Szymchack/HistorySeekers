using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistorySeekers.Models
{
    public class Character
    {
        #region ENUMERABLES

        public enum ExperienceLevel
        {
            Exployer,
            Anthropologist,
            Archeologist
        }

        #endregion

        #region FIELDS

        protected int _id;
        protected string _name;
        protected int _locationId;
        protected int _age;

        protected ExperienceLevel _experience;

        #endregion

        #region PROPERTIES

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int LocationId
        {
            get { return _locationId; }
            set { _locationId = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public ExperienceLevel Experience
        {
            get { return _experience; }
            set { _experience = value; }
        }

        public static object RaceType { get; internal set; }


        #endregion

        #region CONSTRUCTORS

        public Character()
        {

        }

        public Character(string name, ExperienceLevel experience, int locationId)
        {
            _name = name;
            _experience = experience;
            _locationId = locationId;
        }

        #endregion

        #region METHODS

        public virtual string DefaultGreeting()
        {
            return $"Hello, my name is {_name} and I am a {_experience}.";
        }

        #endregion

        
    }
}
