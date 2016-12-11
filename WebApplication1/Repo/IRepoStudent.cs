using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Repo
{
    public interface IRepoStudent
    {
        void addStudent(int idToAdd, string nameToAdd);
        void addSubjectToStudent(Student student, Subject subjectToAdd);
        Student getStudentById(int id);
        List<Student> getStudents();
        void removeSubjectFromStudent(Student student, Subject subjectToRemove);
    }
}