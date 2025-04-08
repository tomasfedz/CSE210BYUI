using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        // Create a list of activities
        // Each activity is an instance of a derived class (Running, Cycling, Swimming)
        List<Activity> activities = new List<Activity> {
            new Running(new DateTime(2022, 11, 3), 30, 3.0),       // 3 miles
            new Cycling(new DateTime(2022, 11, 4), 45, 15.0),      // 15 mph
            new Swimming(new DateTime(2022, 11, 5), 20, 20)        // 20 laps
        };

// Iterate through the list and print the summary of each activity
        foreach (Activity activity in activities) {
            Console.WriteLine(activity.GetSummary());
        }
    }
}