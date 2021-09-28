using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    // implements NotifyPropertyChanged interface for OnPropertyChanged event listener
    public class Player : BaseNotificationClass
    {
        private string _name;
        private string _class;
        private int _hitPoints;
        private int _experiencePoints;
        private int _level;
        private int _gold;

        public string Name 
        {
            get { return _name; }
            set 
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            } 
        }

        public string Class 
        {
            get { return _class; } 
            set
            {
                _class = value;
                OnPropertyChanged(nameof(Class));
            } 
        }

        public int HitPoints 
        { 
            get { return _hitPoints; }
            set
            {
                _hitPoints = value;
                OnPropertyChanged(nameof(HitPoints));
            }
        }

        public int ExperiencePoints 
        {
            get { return _experiencePoints; }
            set 
            { 
                _experiencePoints = value;
                OnPropertyChanged(nameof(ExperiencePoints));
            } 
        }

        public int Level 
        { 
            get { return _level; } 
            set
            {
                _level = value;
                OnPropertyChanged(nameof(Level));
            }
        
        }
        public int Gold 
        { 
            get { return _gold; }
            set
            {
                _gold = value;
                OnPropertyChanged(nameof(Gold));
            } 
        }

    }
}
