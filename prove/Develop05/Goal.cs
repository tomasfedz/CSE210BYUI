using System;
using System.Collections.Generic;
using System.IO;

// Base Goal class
abstract class Goal
{
    protected string _name;
    protected int _points;
    protected bool _isComplete;

/// Constructor for Goal
    /// Initializes the goal with a name, points, and completion status
    public Goal(string name, int points)
    {
        _name = name;
        _points = points;
        _isComplete = false;
    }

/// Properties
    public void SetComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }

/// Method to get the name of the goal
    public virtual int RecordEvent()
    {
        return _points;
    }

    // Updated to include the name by default
    public virtual string GetStatus()
    {
        return $"{(_isComplete ? "[X]" : "[ ]")} {_name}";
    }

    public virtual string GetStringRepresentation()
    {
        return $"{_name},{_points},{_isComplete}";
    }
}