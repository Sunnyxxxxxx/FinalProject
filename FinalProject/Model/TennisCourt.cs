using FinalProject.Model;
using System;
using System.Globalization;

public class TennisCourt : Court
{//definition of the tenniscourt class, properties for the tennis court name,unnique identifier and availbbilty status.
    public string TennisCourtName { get; set; }
    public int TennisCourtId { get; set; }
    public bool IsAvailable { get; set; }

    public TennisCourt(int tenniscourtId, string tenniscourtName) : base(tenniscourtId, tenniscourtName)
    {// constructor that innitializes a tennis court with ID annd nname,setting it to available by default.
        TennisCourtId = tenniscourtId;
        TennisCourtName = tenniscourtName;
        IsAvailable = true;
    }
}