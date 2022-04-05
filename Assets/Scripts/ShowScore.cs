using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour
{
	public GameObject scoreUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate(){
       Text scoreText = scoreUI.GetComponent<Text>();
	   scoreText.text = "Score: " + GameManager.totalNotes;
    }
}
