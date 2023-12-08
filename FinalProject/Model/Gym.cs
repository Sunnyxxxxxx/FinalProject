using FinalProject.Model;
using System;
using System.Globalization;

// Declare the Gym class
public class Gym : Court
{
    // Declare properties specific to store GymName and GymId.
    public string GymName { get; set; }
    public int GymId { get; set; }
    // Constructor for the Gym class with gymId and gymName parameters and the base class constructor.
    public Gym(int gymId, string gymName) : base(gymId, gymName)
    {
        GymId = gymId;
        GymName = gymName;
    }

    // Method to create a new Gym.
    public void CreateGym()
    {
        Gym myGym = new Gym(1, "Main Gym");
    }

}