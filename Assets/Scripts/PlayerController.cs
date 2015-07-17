using UnityEngine;
using System.Collections;

public class PlayerController : Player {

    public static PlayerController playerControl;

    public int count = 0;

    void Awake()
    {
        if (playerControl == null)
        {
            DontDestroyOnLoad(gameObject);
            playerControl = this;
        }
        else if (playerControl != this)
        {
            Destroy(gameObject);
        }
    }

	void Update () 
    {
        CheckInput();
	}

    void CheckInput()
    {
        if (GameController.control.playerTurn == true)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                lastKeyPressed = 1;
                if (startSpawnTime == 0)
                    startSpawnTime = Time.time;
                timeBetweenSpawns = TimeDifference(Time.time);

                ai_blueCheck.DestroySignals();
                SpawnSignal(1);
                //AudioSource.PlayClipAtPoint(spawnSound, Camera.main.transform.position);
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                lastKeyPressed = 2;
                if (startSpawnTime == 0)
                    startSpawnTime = Time.time;
                timeBetweenSpawns = TimeDifference(Time.time);

                ai_redCheck.DestroySignals();
                SpawnSignal(2);
                //AudioSource.PlayClipAtPoint(spawnSound, Camera.main.transform.position);
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                lastKeyPressed = 3;
                if (startSpawnTime == 0)
                    startSpawnTime = Time.time;
                timeBetweenSpawns = TimeDifference(Time.time);

                ai_greenCheck.DestroySignals();
                SpawnSignal(3);
                //AudioSource.PlayClipAtPoint(spawnSound, Camera.main.transform.position);
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                lastKeyPressed = 4;
                if (startSpawnTime == 0)
                    startSpawnTime = Time.time;
                timeBetweenSpawns = TimeDifference(Time.time);

                ai_yellowCheck.DestroySignals();
                SpawnSignal(4);
                //AudioSource.PlayClipAtPoint(spawnSound, Camera.main.transform.position);
            }
        }
    }

    public float TimeDifference(float time)
    {
        timeSinceFirstSignal = time - startSpawnTime;
        float difference = time - lastSpawnTime;
        lastSpawnTime = time;
        return difference;
    }
}
