using UnityEngine;
using System.Collections;

public class MissBarController : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        Vector3 myScale = this.transform.localScale;
        myScale.y = GameController.control.AdjustMissPercent();
        this.gameObject.transform.localScale = myScale;
	}
}
