using FinalProject.Model;
using System;
using System.Globalization;

public class BasketballCourt:Court
{
    public string BasketballCourtName { get; set; }
    public int BasketballCourtId { get; set; }
    public bool IsAvailable { get; set; }

    public BasketballCourt(int basketballcourtId, String basketballcourtName): base(basketballcourtId, basketballcourtName)
    {
        BasketballCourtId = basketballcourtId;
        BasketballCourtName = basketballcourtName;
        IsAvailable = true;
    }
}
