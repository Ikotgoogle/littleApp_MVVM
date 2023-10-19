using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace littleApp_MVVM.Model
{
    public class GroupsOfStudent : PropChange
    {
        private int id;
        private string numberGroup;
        private int headId;
        private int сourse;

        public GroupsOfStudent (int id, string numberGroup, int headId, int course)
        {
            this.id = id;
            this.numberGroup = numberGroup;
            this.headId = headId;
        }

        public int Id { 
            get { return id; } 
            set {  id = value; OnPropertyChanged(nameof(Id)); }
        }
        public string NumberGroup
        {
            get { return numberGroup; }
            set { numberGroup = value; OnPropertyChanged(nameof(NumberGroup)); }
        }

        public int HeadId
        {
            get { return headId; }
            set { headId = value; OnPropertyChanged(nameof(headId)); }
        }

        public int Course
        {
            get { return сourse; }
            set { сourse = value; OnPropertyChanged(nameof(Course)); }
        }
    }
}
