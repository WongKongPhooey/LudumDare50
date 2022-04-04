using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectNote : MonoBehaviour
{
	public bool noteActive;
	public int triggerNum;
	public string triggerKey;
	public GameObject currentNote;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(triggerKey)){
            if(noteActive == true){
				//Debug.Log("SHREDDING");
				AttackLogic.launchAttack(currentNote.name);
				Destroy(currentNote);
				GameManager.trackNotesHit++;
				GameManager.trackCurrentCombo++;
				GameManager.shieldOn = true;
				
				GameManager.notesHit++;
				GameManager.currentCombo++;
			}
        }
    }
	
	public void checkHit(){
		if(noteActive == true){
			//Debug.Log("SHRED NATION");
			Destroy(currentNote);
			GameManager.notesHit++;
			GameManager.currentCombo++;
			GameManager.shieldOn = true;
		}
	}
	
	void OnTriggerEnter2D(Collider2D other) {
		
		if(GameManager.trackTotalNotes == 0){
			//Play track
			SongTracker.playTrack();
		}
		
		noteActive = true;
		currentNote = other.gameObject;
		AttackLogic.launchAttack(currentNote.name);
		GameManager.trackTotalNotes++;
		GameManager.totalNotes++;
	}
	
	void OnTriggerExit2D(Collider2D other) {
		noteActive = false;
		currentNote = null;
	}
	
	bool isActive(){
		if(noteActive == true){
			return true;
		} else {
			return false;
		}
	}
}
