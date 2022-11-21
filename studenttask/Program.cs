using DocumentFormat.OpenXml.Wordprocessing;
using studenttask.Models;

namespace studenttask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Students students = new Students("Fateh", "Aliverdiev", 57);
            Students students3 = new Students("Araz", "Memmedkhanli", 70);
            Students students1 = new Students("Ramal", "Fatullayev", 93);
            Students students2 = new Students("Tural", "Esedli", 86);
            Students students4 = new Students("Tural", "Esedli", 86);
            //Console.WriteLine($"{students.Name} {students.Surname} {students.AvgPoint}");
            Group group = new Group("AB101",5);
            group.Add(students);
            group.Add(students3);
            group.Add(students2);
            group.Add(students1);
            group.Add(students4);
            group.FilterByName("ha");
        }
    }
}