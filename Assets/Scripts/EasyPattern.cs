using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EasyPattern {

    public List<SmokeSignal> smokeSignalPattern = new List<SmokeSignal>();
    public float totalTime;

	// Use this for initialization
	public EasyPattern () 
    {
        smokeSignalPattern.Add(new SmokeSignal(1, 1.0f));
        smokeSignalPattern.Add(new SmokeSignal(2, 1.5f));
        smokeSignalPattern.Add(new SmokeSignal(3, 2.0f));
        smokeSignalPattern.Add(new SmokeSignal(4, 2.5f));
        smokeSignalPattern.Add(new SmokeSignal(1, 3.0f));
        smokeSignalPattern.Add(new SmokeSignal(1, 3.5f));
        smokeSignalPattern.Add(new SmokeSignal(1, 4.0f));
        smokeSignalPattern.Add(new SmokeSignal(2, 8.0f));
        smokeSignalPattern.Add(new SmokeSignal(2, 9.0f));
        smokeSignalPattern.Add(new SmokeSignal(2, 10.0f));
        smokeSignalPattern.Add(new SmokeSignal(1, 11.0f));

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
}
