using System;

namespace Alumnisystem.App.Shared;

public class RoleApplication
{
    public DateOnly DateTime { get; set; }
    public Guid userID { get; set; }
    public Role uRole { get; set; }
    public bool isAdmin { get; set; }
}

public enum Role
{
    Anonymous,
    Registered,
    AlumniProf,
    AlumniStud
}

public class Userdata
{
    public Role uRole { get; set; }
    public Guid userID { get; set; }
    public string name { get; set; }
}