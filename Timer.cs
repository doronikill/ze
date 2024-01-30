using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temer : MonoBehaviour
{
    void Timer timer = new Timer();
       timer.Interval = 1000;

        timer.Elapsed += TemerElapsed;

        timer.AutoReset = true

    private static void TimerElapsed(object sender, ElapsedEventrgs e) {
        Console.WriteLine("Tick");
        timer.AutoReset = true;
    
    }
        
    
}
