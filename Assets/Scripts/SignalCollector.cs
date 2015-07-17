using UnityEngine;
using System.Collections;

public class SignalCollector : MonoBehaviour {

    public bool isPlayerCollector;

    public bool cloudHit;

    public Vector3 disToCloud = new Vector3();
    public float magDis;

    public GameObject whatIsHit;

    public GameObject missSprite;
    public GameObject goodSprite;
    public GameObject greatSprite;

    public AudioClip hitSound;

    public void DestroySignals()
    {
        if (!cloudHit)
        {
            GameController.control.missedClouds++;
            GameController.control.missCalc = GameController.control.missCalc + 10.0f;
            Instantiate(missSprite, (this.gameObject.transform.position + (new Vector3(0.0f, 1.0f, 0.0f))), this.gameObject.transform.rotation);
        }
        else if (magDis <= 0.1f)
        {
            GameController.control.greatClouds++;
            GameController.control.missCalc = GameController.control.missCalc - 4.0f;
            AudioSource.PlayClipAtPoint(hitSound, Camera.main.transform.position);
            Instantiate(greatSprite, (this.gameObject.transform.position + (new Vector3(0.0f, 1.0f, 0.0f))), this.gameObject.transform.rotation);
        }
        else if (magDis <= 0.4f)
        {
            GameController.control.goodClouds++;
            GameController.control.missCalc = GameController.control.missCalc + 2.0f;
            AudioSource.PlayClipAtPoint(hitSound, Camera.main.transform.position);
            Instantiate(goodSprite, (this.gameObject.transform.position + (new Vector3(0.0f, 1.0f, 0.0f))), this.gameObject.transform.rotation);
        }
        Destroy(whatIsHit);
        cloudHit = false;
    }

    void OnTriggerStay(Collider other)
    {
        cloudHit = true;
        whatIsHit = other.gameObject;
        disToCloud = other.gameObject.transform.position - this.gameObject.transform.position;
        magDis = disToCloud.magnitude;
        if (!other.gameObject.activeInHierarchy)
        {
            cloudHit = false;
        }
    }

    void OnTriggerExit(Collider oter)
    {
        cloudHit = false;
        magDis = 0.0f;
    }
}
