using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace littleApp_MVVM.Model
{
    public class Student : PropChange
    {
        private int id;
        private string name;
        private string group;
        private int age;

        public Student(int id, string name, string group, int age)
        {
            Id = id;
            Name = name;
            Group = group;
            Age = age;
            Id = id;
            Name = name;
            Group = group;
            Age = age;
        }

        public int Id 
        { 
            get { return id; } 
            set { id = value; OnPropertyChanged(nameof(Id)); } 
        }

        public string Name 
        { 
            get { return name; } 
            set { name = value; OnPropertyChanged(nameof(Name)); }
        }

        public string Group 
        { 
            get { return group; } 
            set { group = value; OnPropertyChanged(nameof(Group)); }
        }

        public int Age 
        { 
            get { return age;} 
            set { age = value; OnPropertyChanged(nameof(Age)); }
        }
    }
}
