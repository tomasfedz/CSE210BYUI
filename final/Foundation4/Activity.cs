using System;
using System.Collections.Generic;

abstract class Activity {
    private DateTime date;
    private int minutes;

// Constructor to initialize date and minutes
    public Activity(DateTime date, int minutes) {
        this.date = date;
        this.minutes = minutes;
    }

    // Virtual methods for polymorphism
    public virtual double GetDistance() { return 0; } // miles
    public virtual double GetSpeed() { return 0; }   // mph
    public virtual double GetPace() { return 0; }    // min per mile

// Method to get the summary of the activity
    public virtual string GetSummary() {
        return $"{date:dd MMM yyyy} {GetType().Name} ({minutes} min) - " +
               $"Distance: {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph, " +
               $"Pace: {GetPace():F1} min per mile";
    }

    protected int Minutes => minutes; // Protected getter for derived classes
}
