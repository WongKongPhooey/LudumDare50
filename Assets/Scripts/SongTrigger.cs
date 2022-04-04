using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongTrigger : MonoBehaviour
{
	public GameObject songTracker;
	public int songNumber;
	public GameObject noteTile;
	public GameObject noteReel;
	public Vector3 reelStart;
	public Transform noteTrack;
	
    // Start is called before the first frame update
    void Start(){
    }

    // Update is called once per frame
    void Update()
    {
    }
	
	void spawnNotes(Song currentSong){

	}
	
	void OnTriggerEnter2D(Collider2D other) {
	}
}
