using Task_2.Models;
using System.Collections.Generic;

namespace Task_2.DataAccess
{
    public static class Data
    {
       
        public static List<Group> Groups = new List<Group>()
        {
            new Group{ Id = 1, Name = "P101"},
            new Group{ Id = 2, Name = "P102"},
            new Group{ Id = 3, Name = "P103"},
            new Group{ Id = 4, Name = "P104"},
        };

        public static List<Student> Students = new List<Student>()
        {
            new Student{ Id = 1,Name = "Student1", Point = "21"},
            new Student{ Id = 2,Name = "Student2", Point = "22"},
            new Student{ Id = 3,Name = "Student3", Point = "23"},
            new Student{ Id = 4,Name = "Student4", Point = "24"},
        };
    }
}
