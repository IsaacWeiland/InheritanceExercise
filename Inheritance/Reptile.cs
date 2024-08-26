using System;
using System.Collections.Generic;

namespace Inheritance;

public class Reptile : Animal
{
    public List<Reptile> ReptileList { get; set; } = new List<Reptile>();
    public bool IsScaly { get; set; }
    public bool CanCamoflauge { get; set; }
    public bool DoesSlither { get; set; }
    public int SizeInches { get; set; }
    
}