using System;
using System.Collections.Generic;
using System.Text;

namespace Set_Interface_Exercise_1
{
    internal class Student
    {
		private int studentId;
		private String studentName;
		private int courseId;

		public Student(int studentId, String studentName, int courseId)
		{
			this.studentId = studentId;
			this.studentName = studentName;
			this.courseId = courseId;
		}

		public int getStudentId()
		{
			return studentId;
		}

		public void setStudentId(int studentId)
		{
			this.studentId = studentId;
		}

		public String getStudentName()
		{
			return studentName;
		}

		public void setStudentName(String studentName)
		{
			this.studentName = studentName;
		}

		public int getCourseId()
		{
			return courseId;
		}

		public void setCourseId(int courseId)
		{
			this.courseId = courseId;
		}

        public override bool Equals(object student)
		{
			Student otherStudent = (Student)student;
			if (this.studentId == otherStudent.studentId)
				return true;
			return false;
		}

        public override int GetHashCode()
		{
			return studentId;
		}

		
		public override String ToString()
		{
			return "Student Id: " + studentId + ", Student Name: " + studentName;
		}
	}
}
