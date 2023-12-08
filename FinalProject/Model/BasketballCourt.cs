using FinalProject.Model;
using System;
using System.Globalization;

public class BasketballCourt:Court//definition of the basketbballcourt class
{// properties for the basketbal court name,unnique identifier and availbbilty status.
    public string BasketballCourtName { get; set; }
    public int BasketballCourtId { get; set; }
    public bool IsAvailable { get; set; }

    public BasketballCourt(int basketballcourtId, String basketballcourtName): base(basketballcourtId, basketballcourtName)
    {// constructor that innitializes a basketball court with ID annd nname,setting it to available by default.
        BasketballCourtId = basketballcourtId;
        BasketballCourtName = basketballcourtName;
        IsAvailable = true;
    }
}
