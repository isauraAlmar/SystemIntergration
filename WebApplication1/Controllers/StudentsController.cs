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
    /// <summary>
    /// The Students Controller provides the ability to Get, Update, Delete and Create Students within the Database. 
    /// </summary>
    public class StudentsController : ApiController
    {
        private WebApplication1Context db = new WebApplication1Context();
        private IRepoStudent db1 = new RepoStudent();

        // GET: api/Students
        /// <summary>
        /// Get all students from the database.
        /// </summary>
        /// <returns>All students</returns>
        public IQueryable<Student> GetStudents()
        {
            return db.Students;
        }

        // GET: api/Student/5
        /// <summary>
        /// Get a student from the database using the student id.
        /// </summary>
        /// <returns>Student</returns>
        [ResponseType(typeof(Student))]
        public async Task<IHttpActionResult> GetStudent(int id)
        {
            Student student = await db.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        // PUT: api/Students/5
        /// <summary>
        /// Update a student that is within the database using the given id.
        /// </summary>
        /// <returns>Void</returns>
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutStudent(int id, Student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != student.id)
            {
                return BadRequest();
            }

            db.Entry(student).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Students
        /// <summary>
        /// Create a new student within the database.
        /// </summary>
        /// <returns>Void</returns>
        [ResponseType(typeof(Student))]
        public async Task<IHttpActionResult> PostStudent(Student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Students.Add(student);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = student.id }, student);
        }
        /// <summary>
        /// Deletes a student within the database.
        /// </summary>
        /// <returns>Void</returns>
        // DELETE: api/Students/5
        [ResponseType(typeof(Student))]
        public async Task<IHttpActionResult> DeleteStudent(int id)
        {
            Student student = await db.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }

            db.Students.Remove(student);
            await db.SaveChangesAsync();

            return Ok(student);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool StudentExists(int id)
        {
            return db.Students.Count(e => e.id == id) > 0;
        }
    }
}