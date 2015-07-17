using UnityEngine;
using System.Collections;

public class TextPopup : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("FadeOut", 1.0f);
	}
	
    void FadeOut()
    {
        Destroy(this.gameObject);
    }
}
