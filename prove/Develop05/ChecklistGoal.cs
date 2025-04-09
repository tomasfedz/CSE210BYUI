using System;
using System.Collections.Generic;
using System.IO;

class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

/// Constructor for ChecklistGoal
    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints) 
        : base(name, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonusPoints = bonusPoints;
    }

// method to set the current count of the goal
    public void SetCurrentCount(int count)
    {
        _currentCount = count;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _currentCount++;
            if (_currentCount >= _targetCount)
            {
                _isComplete = true;
                return _points + _bonusPoints;
            }
            return _points;
        }
        return 0;
    }

    // Already includes the name, just keeping it consistent
    public override string GetStatus()
    {
        return $"{base.GetStatus()} (Completed {_currentCount}/{_targetCount} times)";
    }
/// Method to get the string representation of the goal
    /// This method is used to save the goal to a file
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{base.GetStringRepresentation()},{_targetCount},{_currentCount},{_bonusPoints}";
    }
}
