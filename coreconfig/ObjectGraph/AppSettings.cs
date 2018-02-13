using System.ComponentModel.DataAnnotations; // <<<<<<<<<<<<<<<<<<<

public class AppSettings
{
    [Required]  // <<<<<<<<<<<<<<<<<<<
    public int i { get; set; }
    public int? i2 { get; set; }

    [Required]  // <<<<<<<<<<<<<<<<<<<
    public int i3 { get; set; }

    [Required]  // <<<<<<<<<<<<<<<<<<<
    public string s { get; set; }

    public Window Window { get; set; }
    public Connection Connection { get; set; }
    public Profile Profile { get; set; }
}

public class Window
{
    [Required]  // <<<<<<<<<<<<<<<<<<<
    public int Depth { get; set; }

    public int Height { get; set; }
    public int Width { get; set; }
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
