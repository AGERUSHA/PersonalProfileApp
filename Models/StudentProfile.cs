namespace PersonalProfileApp.Models
{
    // Студент туралы мәліметтер (Model)
    public class StudentProfile
    {
        public string FullName { get; set; } = "";
        public string Group { get; set; } = "";
        public string University { get; set; } = "";
        public string Bio { get; set; } = "";
        public List<string> Skills { get; set; } = new();
        public string Email { get; set; } = "";
        public string Phone { get; set; } = "";
        public string GitHub { get; set; } = "";
        public List<Project> Projects { get; set; } = new();
    }

    public class Project
    {
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public string Technologies { get; set; } = "";
    }
}
