using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowScore : MonoBehaviour
{
	public GameObject scoreUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
       Text scoreText = scoreUI.GetComponent<Text>();
	   scoreText.text = "Score: " + GameManager.totalNotes;
    }
}
