using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	
	public GameObject scoreUI;
	
	public static int notesHit;
	public static int totalNotes;
	public static float accuracy;
	public static int currentCombo;
	
	public static int health;
	
    // Start is called before the first frame update
    void Start(){
    }

    // Update is called once per frame
    void Update(){
       Text scoreText = scoreUI.GetComponent<Text>();
	   scoreText.text = "Score: " + notesHit + " Combo: " + currentCombo;
    }
}
