using System;
using System.Collections.Generic;

namespace Inheritance;

public class Bird : Animal
{
    public List<Bird> BirdsList { get; set; } = new List<Bird>();
    public bool CanFly { get; set; }
    public string FeatherColor { get; set; }
    public string MatingCry { get; set; }

    public static void MigrationSeason()
    {
        Console.WriteLine("A bird's migration season is in the winter.");
    }

}