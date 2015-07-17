using UnityEngine;
using System.Collections;

public class Pawn : MonoBehaviour {

    public GameObject blueCollector;
    public GameObject redCollector;
    public GameObject greenCollector;
    public GameObject yellowCollector;

    public GameObject cloudSpawn;

    public float lastKeyPressed;

    public AudioClip spawnSound;

    public void SpawnSignal(float signalKey)
    {
        if (signalKey == 1.0f)
        {
            Instantiate(cloudSpawn, (this.gameObject.transform.position + (new Vector3(0.0f, 0.0f, 0.0f))), this.gameObject.transform.rotation);
        }
        if (signalKey == 2.0f)
        {
            Instantiate(cloudSpawn, (this.gameObject.transform.position + (new Vector3(0.0f, 0.0f, 0.0f))), this.gameObject.transform.rotation);
        }
        if (signalKey == 3.0f)
        {
            Instantiate(cloudSpawn, (this.gameObject.transform.position + (new Vector3(0.0f, 0.0f, 0.0f))), this.gameObject.transform.rotation);
        }
        if (signalKey == 4.0f)
        {
            Instantiate(cloudSpawn, (this.gameObject.transform.position + (new Vector3(0.0f, 0.0f, 0.0f))), this.gameObject.transform.rotation);
        }
    }
}

public class Player : Pawn
{
    public float startSpawnTime;
    public float timeSinceFirstSignal;
    public float timeBetweenSpawns;
    public float lastSpawnTime;

    public SignalCollector ai_blueCheck;
    public SignalCollector ai_redCheck;
    public SignalCollector ai_greenCheck;
    public SignalCollector ai_yellowCheck;
}

public class SignalSpawner : Pawn
{
    public float lastSpawnTime;
}
