using System;
using System.Collections.Generic;
using System.IO;

class EternalGoal : Goal
{
    /// Constructor for EternalGoal
    /// inherits from the base Goal class
    public EternalGoal(string name, int points) : base(name, points) { }

    /// Method to record an event for the goal
    public override int RecordEvent()
    {
        return _points;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{base.GetStringRepresentation()}";
    }
}