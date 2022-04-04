using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

	public GameObject scoreUI;
	public GameObject comboUI;

	public GameObject healthUI;
	public GameObject shield;
	
	public static int notesHit;
	public static int totalNotes;
	public static float accuracy;
	public static int currentCombo;

	
	public static int trackNotesHit;
	public static int trackTotalNotes;
	public static float trackAccuracy;
	public static int trackCurrentCombo;
	


    public GameObject playerCharacter;


	public static int health;
	public static bool shieldOn;

    public GameObject gameOverUI;
    public GameObject winUI;
    public static bool bossDead = false;

    public bool firstTime; // used to stop every update deletion attempts



 
    // Start is called before the first frame update
    void Start(){

       trackNotesHit = 0;
	   trackTotalNotes = 0;
	   trackAccuracy = 0;
	   trackCurrentCombo = 0;
       firstTime = true;
       bossDead = false;

        health = 50;

    }

    // Update is called once per frame
    void Update(){
       Text scoreText = scoreUI.GetComponent<Text>();
        //scoreText.text = "Score: " + notesHit;
        scoreText.text = "" + notesHit;

        Text comboText = comboUI.GetComponent<Text>();
	   comboText.text = "x" + currentCombo + "";
	   
	   Text healthText = healthUI.GetComponent<Text>();
	   healthText.text = "Health: " + health;
	   
	   if(shieldOn == true){
		   shield.SetActive(true);
	   } else {
		   shield.SetActive(false);
	   }
	   
	   if(health <= 0 && firstTime == true){
		   health = 0;
            Destroy(playerCharacter.GetComponent<CharacterController2D>());
            Destroy(playerCharacter.GetComponent<PlayerMovement>()); // stop player moving
            playerCharacter.GetComponent<PlayerMovement>().dead = true;
            playerCharacter.GetComponent<Animator>().SetBool("IsDead", true);
            Destroy(playerCharacter.transform.GetChild(0).gameObject); // destroy particles
            Debug.Log("DEAD");
            firstTime = false;

            StartCoroutine(EndGame()); // Win/Lose state
	   }
	   
	   if(bossDead == true && firstTime == true)
        {
		   Destroy(playerCharacter.GetComponent<CharacterController2D>());
          //  Destroy(playerCharacter.GetComponent<PlayerMovement>()); // stop player moving
           // playerCharacter.GetComponent<PlayerMovement>().dead = true;
          //  playerCharacter.GetComponent<Animator>().SetBool("IsDead", true);
            Destroy(playerCharacter.transform.GetChild(0).gameObject); // destroy particles
           // Debug.Log("DEAD");
            firstTime = false;
			
			StartCoroutine(EndGame());
	   }
    }

    public IEnumerator EndGame()
    {
        yield return new WaitForSeconds(2.5f);

        Time.timeScale = 0f;
        if(health <= 0)
        {
            Instantiate(gameOverUI, transform.position, transform.rotation);
        }
        else
        {
            GameObject winInst = Instantiate(winUI, transform.position, transform.rotation);
            Text finalScore = GameObject.Find("WinScoreText").GetComponent<Text>();
            Debug.Log(finalScore.text);
            finalScore.text = "Score: " + notesHit + "/" + totalNotes;
        }
        yield return null;

    }
    

}
