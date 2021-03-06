﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StudentSwagWebApi.Controllers
{
    [Route("api/Student")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        string connection = "server=DESKTOP-MI37MO8\\SQLEXPRESS;Integrated Security=true;Initial Catalog=Practice";

        [HttpGet]
        public async Task<List<Student>> Get()
        {
            List<Student> students = new List<Student>();
            SqlConnection dbConnection = new SqlConnection(connection);
            dbConnection.Open();
            SqlCommand dbCommand = new SqlCommand("Select * from Student", dbConnection);
            SqlDataReader sqlDataReader = await dbCommand.ExecuteReaderAsync();

            while (sqlDataReader.Read())
            {
                Student student = new Student();
                student.Id = sqlDataReader.GetInt32(0);
                student.Name = sqlDataReader.GetString(1);
                student.Gender = sqlDataReader.GetString(2);
                student.Subject = sqlDataReader.IsDBNull(3) ? 0 : sqlDataReader.GetInt32(3);
                students.Add(student);
            }

            dbConnection.Close();
            return students;
        }

        [HttpPost]
        public async Task CreateStudent(Student student)
        {
            SqlConnection dbConnection = new SqlConnection(connection);
            dbConnection.Open();
            string insertStatement = " insert into student(name,subject,gender) values (" + "'" + student.Name + "'," + "'" + student.Subject + "'," + "'" + student.Gender + "')";
            SqlCommand dbCommand = new SqlCommand(insertStatement, dbConnection);
            await dbCommand.ExecuteNonQueryAsync();
            dbConnection.Close();
            // return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateStudent(int studentId,Student student)
        {
            SqlConnection dbConnection = new SqlConnection(connection);
            dbConnection.Open();
            string updateStatement = " update student set name = '" + student.Name + "',subject = '" + student.Subject + "', gender = '" + student.Gender + "' where id = " + student.Id;
            SqlCommand dbCommand = new SqlCommand(updateStatement, dbConnection);
            await dbCommand.ExecuteNonQueryAsync();
            dbConnection.Close();
            return Ok();
        }


        [HttpDelete]
        public async Task<ActionResult> DeleteStudent(int studentId)
        {
            SqlConnection dbConnection = new SqlConnection(connection);
            dbConnection.Open();
            string deleteStatement = " delete student where id = " + studentId;
            SqlCommand dbCommand = new SqlCommand(deleteStatement, dbConnection);
            await dbCommand.ExecuteNonQueryAsync();
            dbConnection.Close();
            return Ok();
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Subject { get; set; }
    }
}