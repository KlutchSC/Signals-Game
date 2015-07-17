using UnityEngine;
using System.Collections;

public class AIController : SignalSpawner {
    
    public static AIController aiControl;
    int count = 0;

    void Awake()
    {
        if (aiControl == null)
        {
            DontDestroyOnLoad(gameObject);
            aiControl = this;
        }
        else if (aiControl != this)
        {
            Destroy(gameObject);
        }
    }

	void Start ()
    {

	}

    void Update()
    {
        if (GameController.control.aiTurn)
            ReadSmokePattern();
    }

    public void ReadSmokePattern()
    {
        //if (count < GameController.control.randomSpawn.smokeSignalPattern.Count)
        //{
            if ((GameController.control.aiSpawnTimer - lastSpawnTime) >= GameController.control.randomSpawn.smokeSignalPattern[count].timing)
            {
                Debug.Log(GameController.control.randomSpawn.smokeSignalPattern[count].keyValue + " was pressed with time of " + GameController.control.randomSpawn.smokeSignalPattern[count].timing);
                lastSpawnTime = GameController.control.aiSpawnTimer;
                GameController.control.randomSpawn.CreatePattern(GameController.control.difficulty);
                lastKeyPressed = GameController.control.randomSpawn.smokeSignalPattern[count].keyValue;
                SpawnSignal(GameController.control.randomSpawn.smokeSignalPattern[count].keyValue);
                AudioSource.PlayClipAtPoint(spawnSound, Camera.main.transform.position);
                count++;
            }
        //}
    }
}
