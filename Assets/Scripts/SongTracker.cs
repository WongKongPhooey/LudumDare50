using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongTracker : MonoBehaviour
{
	static string songName;
	int songSpeed;
	float songPoint;
	public GameObject noteTile;
	public GameObject noteReel;
	public Transform noteTrack;
	public Song currentSong;
	
    void Start(){
		//Buys some time before the track plays
        songSpeed = 150;
		
		//currentSong = (Song)Resources.Load("Songs/Easy/" + songName);
		
		if(currentSong != null){
			spawnNotes(currentSong);
		} else {
			Debug.Log("No song loaded");
		}
    }

    // Update is called once per frame
    void Update(){
		noteReel.transform.position -= new Vector3(-songSpeed * Time.deltaTime,0f,0f);
    }
	
	void spawnNotes(Song currentSong){
		int noteIndex = 0;
		List<int> notes = currentSong.notes;
		List<int> keys = currentSong.keys;
		
		foreach(int note in notes){
			int key = keys[noteIndex];
			GameObject noteInst = Instantiate(noteTile, new Vector3(-note * 60, -(key-1) * 75, transform.position.z) , Quaternion.identity);
			noteInst.transform.SetParent(noteTrack, false);
			noteIndex++;
		}
	}
}
