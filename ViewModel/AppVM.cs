using littleApp_MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace littleApp_MVVM.ViewModel
{
    public class AppVM : PropChange
    {
        public ObservableCollection<Student> Students { get; set; }
        public ObservableCollection<GroupsOfStudent> Groups { get; set; }

        private GroupsOfStudent selectedGroup;       
        private Student chouseStudent;
        public GroupsOfStudent SelectedGroup
        {
            get { return selectedGroup; }
            set { OnPropertyChanged(nameof(SelectedGroup)); selectedGroup = value; }
        }

        public Student ChooseStudent
        {
            get { 
                return chouseStudent;
            }
            set 
            { 
                chouseStudent = value; 
                OnPropertyChanged(nameof(ChooseStudent));  
            }

        }

        private RelayCommand removeStudent;
        public RelayCommand RemoveStudent
        {
            get
            {
                return removeStudent ??
                    (removeStudent = new RelayCommand(obj => {
                        Students.Remove(ChooseStudent);
                    }));
            }            
        }


        public AppVM() 
        {
            Groups = new ObservableCollection<GroupsOfStudent>(DataContext.DataBase.groups);
            Students = new ObservableCollection<Student>(DataContext.DataBase.students);
        }

        private void ChoouseStudent(string group)
        {
            ChooseStudent = new ObservableCollection<Student>(Students.Where(q => q.Group == group));
        }
    }
}
