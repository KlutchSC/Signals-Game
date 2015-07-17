using UnityEngine;
using System.Collections;

public class SmokeSignal
{
    public float keyValue { get; set; }
    public float timing { get; set; }

    public SmokeSignal (int key, float time)
    {
        keyValue = key;
        timing = time;
    }
}
