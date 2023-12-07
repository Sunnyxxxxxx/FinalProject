using FinalProject.Model;
using System;
using System.Globalization;

public class Gym : Court
{
    public string GymName { get; set; }
    public int GymId { get; set; }

    public Gym(int gymId, string gymName) : base(gymId, gymName)
    {
        GymId = gymId;
        GymName = gymName;
    }

    public void CreateGym()
    {
        Gym myGym = new Gym(1, "Main Gym");
    }

}