using ES.Domain.Context;
using ES.Domain.Entities;
using ES.Repository.IRespository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Repository.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly MyDbContext _dbContext;

        public StudentRepository(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> Add(Student student)
        {
            await _dbContext.Students.AddAsync(student);
            int entry = await _dbContext.SaveChangesAsync();
            return entry;
        }

        public  async Task<int> Delete(int id)
        {
            Student student = await _dbContext.Students.FindAsync(id);
            _dbContext.Students.Remove(student);
            int entry = await _dbContext.SaveChangesAsync();
            return entry;
        }

        public async Task<List<Student>> GetAll()
        {
            List<Student> students = await _dbContext.Students.Include("Exam").Include("ExamResults").Include("QuestionAns").ToListAsync();
            return students;
        }

        public async Task<Student> GetById(int id)
        {
            Student student = await _dbContext.Students.Include("Exam").Include("ExamResults").Include("QuestionAns").Where(x => x.StudentId == id).FirstOrDefaultAsync();
            return student;
        }

        public async Task<int> Update(Student student)
        {
            int entry = 0;
            Student oldstudent = await _dbContext.Students.FindAsync(student.StudentId);
            if (oldstudent == null)
            {
                oldstudent.StudentName = student.StudentName;
                oldstudent.PhoneNumber = student.PhoneNumber;
                oldstudent.UserName = student.UserName;
                oldstudent.UserEmail = student.UserEmail;
                oldstudent.Password = student.Password;

                entry = await _dbContext.SaveChangesAsync();
            }

            return entry;
        }
    }
}
