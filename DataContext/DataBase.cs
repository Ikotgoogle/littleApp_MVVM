using littleApp_MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace littleApp_MVVM.DataContext
{
    public static class DataBase
    {
        public static ObservableCollection<Student> students = new ObservableCollection<Student>() {
            new Student(1, "Ivan", groups[1].NumberGroup, 17),
            new Student(2, "Misha", groups[1].NumberGroup, 16),
            new Student(3, "Kolya", groups[2].NumberGroup, 18),
            new Student(4, "Petya", groups[2].NumberGroup, 19),
            new Student(5, "Sasha", groups[0].NumberGroup, 16),
            new Student(6, "Maxim", groups[0].NumberGroup, 17)
            };

        public static ObservableCollection<GroupsOfStudent> groups = new ObservableCollection<GroupsOfStudent>()
        {
            new GroupsOfStudent(1, "a1", 1, 1),
            new GroupsOfStudent(1, "a2", 1, 1),
            new GroupsOfStudent(1, "a3", 1, 1)
        };
    }
}
