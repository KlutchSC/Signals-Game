using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public static GameController control;

    public int missedClouds;
    public int goodClouds;
    public int greatClouds;

    public bool playerTurn;
    public float playerDelay;
    public bool aiTurn;
    public float aiDelay = 2.0f;

    public float gameTime;
    public float aiSpawnTimer;

    public const float missPercent = 100.0f;
    public float missCalc = 0.0f;

    public int difficulty;

    public GameObject startButton;
    public GameObject easyButton;
    public GameObject hardButton;

    bool moveControls = false;

    //public EasyPattern firstSpawn = new EasyPattern();
    public RandomPattern randomSpawn = new RandomPattern();

    void Awake()
    {
        if (control == null)
        {
            DontDestroyOnLoad(gameObject);
            control = this;
        }
        else if (control != this)
        {
            Destroy(gameObject);
        }
    }

	void Start ()
    {
        playerTurn = false;
        aiTurn = false;
        Invoke("StartAITurn", aiDelay);
	}

    void Update()
    {
        if (moveControls)
            MoveControls();
        gameTime = Time.time;
        aiSpawnTimer = gameTime - aiDelay;
    }

    void StartPlayerTurn()
    {
        playerTurn = true;
    }

    void StartAITurn()
    {
        aiTurn = true;
        Invoke("StartPlayerTurn", 2.0f);
    }

    public float AdjustMissPercent()
    {
        float basePercent;
        basePercent = missPercent - missCalc;
        if (basePercent > 100.0f)
            basePercent = 100.0f;
        if (basePercent <= 0.0f)
            basePercent = 0.0f;
        return basePercent / missPercent;
    }

    public void MenuControls(string button)
    {
        if (button == "start")
        {
            moveControls = true;
        }
    }

    public void MoveControls()
    {
        startButton.transform.position = Vector3.MoveTowards(startButton.transform.position, (this.transform.position + (new Vector3(-500.0f, startButton.transform.position.y, this.transform.position.z))), (200.0f * Time.deltaTime));
        easyButton.transform.position = Vector3.MoveTowards(easyButton.transform.position, (this.transform.position + (new Vector3(500.0f, easyButton.transform.position.y, this.transform.position.z))), (200.0f * Time.deltaTime));
        hardButton.transform.position = Vector3.MoveTowards(hardButton.transform.position, (this.transform.position + (new Vector3(500.0f, hardButton.transform.position.y, this.transform.position.z))), (200.0f * Time.deltaTime));
    }

    public void LoadGame(int level)
    {
        if (level == 1)
        {
            difficulty = 1;
        }
        else if (level == 2)
        {
            difficulty = 2;
        }
        moveControls = false;
        Application.LoadLevel(1);
    }
}
