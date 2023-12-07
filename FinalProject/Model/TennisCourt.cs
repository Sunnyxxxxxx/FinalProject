using FinalProject.Model;
using System;
using System.Globalization;

public class TennisCourt : Court
{
    public string TennisCourtName { get; set; }
    public int TennisCourtId { get; set; }
    public bool IsAvailable { get; set; }

    public TennisCourt(int tenniscourtId, string tenniscourtName) : base(tenniscourtId, tenniscourtName)
    {
        TennisCourtId = tenniscourtId;
        TennisCourtName = tenniscourtName;
        IsAvailable = true;
    }
}