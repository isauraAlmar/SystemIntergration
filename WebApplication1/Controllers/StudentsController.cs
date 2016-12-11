using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using WebApplication1.Models;
using WebApplication1.Repo;

namespace WebApplication1.Controllers
{
    public class StudentsController : ApiController
    {
        private IRepoStudent db = new RepoStudent();

        // GET: api/Students
        public List<Student> GetStudents()
        {
            return db.getStudents();
        }


        // I have commented this out for some reason it needs to be modifyed a little bit. 

        // i recommand you getting postman extension from google chrome. hassan or someone might be able to tell you more about it.

        // http://localhost:53119/api/Students you should be able to test it out with that link. you will post that in post man or just in your google chrome if it is working 
        // it should return two students in XML format then you came try and implament maybe get by id



        //// GET: api/Student/5
        //[ResponseType(typeof(Student))]
        //public async Task<IHttpActionResult> GetStudent(int id)
        //{
        //    Student student = await db.Students.FindAsync(id);
        //    if (student == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(student);
        //}

        //// PUT: api/Students/5
        //[ResponseType(typeof(void))]
        //public async Task<IHttpActionResult> PutStudent(int id, Student student)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != student.id)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(student).State = EntityState.Modified;

        //    try
        //    {
        //        await db.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!StudentExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        //// POST: api/Students
        //[ResponseType(typeof(Student))]
        //public async Task<IHttpActionResult> PostStudent(Student student)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.Students.Add(student);
        //    await db.SaveChangesAsync();

        //    return CreatedAtRoute("DefaultApi", new { id = student.id }, student);
        //}

        //// DELETE: api/Students/5
        //[ResponseType(typeof(Student))]
        //public async Task<IHttpActionResult> DeleteStudent(int id)
        //{
        //    Student student = await db.Students.FindAsync(id);
        //    if (student == null)
        //    {
        //        return NotFound();
        //    }

        //    db.Students.Remove(student);
        //    await db.SaveChangesAsync();

        //    return Ok(student);
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private bool StudentExists(int id)
        //{
        //    return db.Students.Count(e => e.id == id) > 0;
        //}
    }
}