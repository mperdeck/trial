using System.ComponentModel.DataAnnotations; // <<<<<<<<<<<<<<<<<<<

public class AppSettings
{
    public Window Window { get; set; }
    public Connection Connection { get; set; }
    public Profile Profile { get; set; }
}

public class Window
{
    public int Height { get; set; }
    public int Width { get; set; }
    public int Depth { get; set; }
    public int Depth2 { get; set; } = 45;
    public bool b { get; set; }
    public bool b2 { get; set; } = true;
}

public class Connection
{
    public string Value { get; set; }

    [Required]  // <<<<<<<<<<<<<<<<<<<
    public string Value2 { get; set; }
    public string Value3 { get; set; } = "this is value 3";
}

public class Profile
{
    public string Machine { get; set; }
}
