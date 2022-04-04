using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongTracker : MonoBehaviour
{
	int songNumber;
	static string songName;
	int songSpeed;
	float songPoint;
	public GameObject noteTile;
	public GameObject noteReel;
	public Vector3 reelStart;
	public Transform noteTrack;
	public Song currentSong;
	
	public AudioClip currentAudio;
	AudioSource audioPlayer;
	
    void Start(){
		//Buys some time before the track plays
        GameManager.health = 100;
		
		songSpeed = 120;
		
		audioPlayer = GetComponent<AudioSource>();
		
		reelStart = noteReel.transform.position;
		
		//currentSong = (Song)Resources.Load("Songs/Easy/" + songName);
		
		if(currentSong != null){
			songNumber = currentSong.trackNumber;
			songSpeed = currentSong.trackSpeed;
			currentAudio = (AudioClip)Resources.Load("Songs/Audio/Track " + songNumber);
			audioPlayer.PlayOneShot(currentAudio);
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
		List<string> attackNotes = currentSong.attacks;
		
		foreach(int note in notes){
			int key = keys[noteIndex];
			GameObject noteInst = Instantiate(noteTile, new Vector3(-note * 60, -(key-1) * 75, transform.position.z) , Quaternion.identity);
			if(attackNotes[noteIndex] != ""){
				noteInst.name = "" + attackNotes[noteIndex] + "";
			} else {
				noteInst.name = "Note";
			}
			noteInst.transform.SetParent(noteTrack, false);
			noteIndex++;
		}
	}
	
	public void nextTrack(){
		songNumber++;
		currentSong = (Song)Resources.Load("Songs/Hard/Track " + songNumber);
		currentAudio = (AudioClip)Resources.Load("Songs/Audio/Track " + songNumber);
		audioPlayer.PlayOneShot(currentAudio);
		//Debug.Log("Searching in Songs/Hard/Track " + songNumber);
		songSpeed = currentSong.trackSpeed;
		spawnNotes(currentSong);
		noteReel.transform.position = reelStart;
	}
}
