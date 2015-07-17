using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShowGameText : MonoBehaviour {

    Text missesText;
    
	// Use this for initialization
	void Start () {
        missesText = this.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
	    missesText.text = "Misses: " + GameController.control.missedClouds;
	}
}
