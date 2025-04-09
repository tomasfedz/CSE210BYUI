using System;
using System.Collections.Generic;
using System.IO;


class SimpleGoal : Goal
{
    /// Constructor for SimpleGoal
    public SimpleGoal(string name, int points) : base(name, points) { }
    
    
    /// Method to record an event for the goal
    /// If the goal is not complete, it marks it as complete and returns the points
    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }
        return 0;
    }
/// Already includes the name, just keeping it consistent
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{base.GetStringRepresentation()}";
    }
}