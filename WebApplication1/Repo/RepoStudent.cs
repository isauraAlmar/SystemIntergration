using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Repo
{
    public class RepoStudent : IRepoStudent
    {
        public static List<Student> studentsList = new List<Student>();

        public static Student Isaura = new Student() { id = 1, name = "Isaura" };
        public static Student Michael = new Student() { id = 2, name = "Michael" };

        public List<Student> getStudents()
        {
            studentsList.Add(Isaura);
            studentsList.Add(Michael);

            return studentsList;
        }

        public Student getStudentById(int id)
        {
            Student student = studentsList.Where(x => x.id == id).First();

            return student;
        }

        public void addStudent(int idToAdd, string nameToAdd)
        {
            Student studentToAdd = new Student() { id = idToAdd, name = nameToAdd };

            studentsList.Add(studentToAdd);
        }

        public void addSubjectToStudent(Student student, Subject subjectToAdd)
        {
            Student studentToAddSubject = studentsList.Where(x => x.id == student.id).First();

            student.listOfSubjects.Add(subjectToAdd);
        }

        public void removeSubjectFromStudent(Student student, Subject subjectToRemove)
        {
            Student studentToAddSubject = studentsList.Where(x => x.id == student.id).First();

            student.listOfSubjects.Remove(subjectToRemove);
        }

    }

}