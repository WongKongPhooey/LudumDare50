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
				Debug.Log("SHREDDING");
				Destroy(currentNote);
			}
        }
    }
	
	void OnTriggerEnter2D(Collider2D other) {
		noteActive = true;
		currentNote = other.gameObject;
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
