using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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

    public GameObject gameOverUI;
    public GameObject winUI;
    public bool BossDead = false;

    // Start is called before the first frame update
    void Start(){
       //EndGame(); //Endgame needs to be triggered to ping up correct ui
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
           EndGame(); // Win/Lose state
	   }
    }

    void EndGame()
    {
        Time.timeScale = 0f;
        if( BossDead == false)
        {
            Instantiate(gameOverUI, transform.position, transform.rotation);
        }
        else
        {
            Instantiate(winUI, transform.position, transform.rotation);
        }
        

    }

    
}
