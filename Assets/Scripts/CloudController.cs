using UnityEngine;
using System.Collections;

public class CloudController : MonoBehaviour {

    float posMoveTo;

    public bool playerCloud;
    public SpriteRenderer render;

    public Material blue;
    public Material red;
    public Material green;
    public Material yellow;

    public float moveSpeed;

	// Use this for initialization
	void Start () {
        render = this.GetComponent<SpriteRenderer>();
        if (playerCloud == true)
            posMoveTo = PlayerController.playerControl.lastKeyPressed;
        else
            posMoveTo = AIController.aiControl.lastKeyPressed;
        Invoke("DestroyMe", 2.1f);
	}
	
	// Update is called once per frame
	void Update () {
        MoveToCollector(posMoveTo);
	}

    GameObject OnTriggerEnter(Collider other)
    {
        return other.gameObject;
    }

    void MoveToCollector(float pos)
    {
        if (playerCloud == true)
        {
            if (pos == 1)
            {
                //render.material = blue;
                transform.position = Vector3.MoveTowards(transform.position, PlayerController.playerControl.blueCollector.transform.position, (moveSpeed * Time.deltaTime));
            }
            if (pos == 2)
            {
                //render.material = red;
                transform.position = Vector3.MoveTowards(transform.position, PlayerController.playerControl.redCollector.transform.position, (moveSpeed * Time.deltaTime));
            }
            if (pos == 3)
            {
                //render.material = green;
                transform.position = Vector3.MoveTowards(transform.position, PlayerController.playerControl.greenCollector.transform.position, (moveSpeed * Time.deltaTime));
            }
            if (pos == 4)
            {
                //render.material = yellow;
                transform.position = Vector3.MoveTowards(transform.position, PlayerController.playerControl.yellowCollector.transform.position, (moveSpeed * Time.deltaTime));
            }
        }
        else
        {
            if (pos == 1)
            {
                //render.material = blue;
                transform.position = Vector3.MoveTowards(transform.position, AIController.aiControl.blueCollector.transform.position, (moveSpeed * Time.deltaTime));
            }
            if (pos == 2)
            {
                //render.material = red;
                transform.position = Vector3.MoveTowards(transform.position, AIController.aiControl.redCollector.transform.position, (moveSpeed * Time.deltaTime));
            }
            if (pos == 3)
            {
                //render.material = green;
                transform.position = Vector3.MoveTowards(transform.position, AIController.aiControl.greenCollector.transform.position, (moveSpeed * Time.deltaTime));
            }
            if (pos == 4)
            {
                //render.material = yellow;
                transform.position = Vector3.MoveTowards(transform.position, AIController.aiControl.yellowCollector.transform.position, (moveSpeed * Time.deltaTime));
            }
        }
    }

    void DestroyMe()
    {
        if (!playerCloud)
            GameController.control.missedClouds++;
        Destroy(this.gameObject);
    }
}
