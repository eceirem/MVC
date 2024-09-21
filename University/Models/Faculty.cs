namespace University.Models
{
	public class Faculty
	{
		public int FacultyId {get; set;}
		public string FacultyName {get; set;}

		public IEnumerable<Department> Departments { get; set; } = new List<Department>();

	}
}
