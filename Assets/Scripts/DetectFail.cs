using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectFail : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
	
	void OnTriggerEnter2D(Collider2D other) {
		GameManager.currentCombo = 0;
		GameManager.shieldOn = false;
		Destroy(other.gameObject);
	}
}
