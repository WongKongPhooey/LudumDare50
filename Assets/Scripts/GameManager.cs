using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	
	public GameObject scoreUI;
	public GameObject healthUI;
	public GameObject shield;
	
	public static int notesHit;
	public static int totalNotes;
	public static float accuracy;
	public static int currentCombo;
	
	public static int health;
	public static bool shieldOn;
	
    // Start is called before the first frame update
    void Start(){
    }

    // Update is called once per frame
    void Update(){
       Text scoreText = scoreUI.GetComponent<Text>();
	   scoreText.text = "Score: " + notesHit + " Combo: " + currentCombo;
	   
	   Text healthText = healthUI.GetComponent<Text>();
	   healthText.text = "Health: " + health;
	   
	   if(shieldOn == true){
		   shield.SetActive(true);
	   } else {
		   shield.SetActive(false);
	   }
	   
	   if(health <= 0){
		   health = 0;
		   Debug.Log("DEAD");
		   // Win/Lose state
	   }
    }
}
