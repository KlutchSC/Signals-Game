using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RandomPattern {

	public List<SmokeSignal> smokeSignalPattern = new List<SmokeSignal>();
    public float totalTime;

	// Use this for initialization
	public RandomPattern () 
    {
        smokeSignalPattern.Add(new SmokeSignal(1, 1.0f));
        smokeSignalPattern.Add(new SmokeSignal(1, 1.0f));
	}
	
    public void PlaySmokePattern()
    {
        foreach (SmokeSignal signalQueue in smokeSignalPattern)
        {
            Debug.Log("Press key " + signalQueue.keyValue + "at elapsed time " + signalQueue.timing);
        }
    }

    public float AddTiming()
    {
        foreach (SmokeSignal signalTime in smokeSignalPattern)
        {
            totalTime = totalTime + signalTime.timing;
        }
        return totalTime;
    }

    public void CreatePattern(int difficulty)
    {
        float timing = 0.0f;
        if (difficulty == 1)
        {
            timing = 1.0f;
        }
        else if (difficulty == 2)
        {
            timing = 0.4f;
        }
        int k = Random.Range(1, 5);
        smokeSignalPattern.Add(new SmokeSignal(k, timing));
    }
}
