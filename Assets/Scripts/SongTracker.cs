using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongTracker : MonoBehaviour
{
	static int songNumber;
	static string songName;
	int songSpeed;
	float songPoint;
	public GameObject noteTile;
	public GameObject noteReel;
	public Vector3 reelStart;
	public Transform noteTrack;
	public static Song currentSong;
	
	public AudioClip currentAudio;
	public static AudioSource audioPlayerSt;
	AudioSource audioPlayer;
	
    void Start(){
		
		//Buys some time before the track plays
        GameManager.health = 100;
		
		songSpeed = 0;
		
		audioPlayer = GetComponent<AudioSource>();
		audioPlayerSt = audioPlayer;
		
		reelStart = noteReel.transform.position;
		
		currentSong = (Song)Resources.Load("Songs/Hard/Track 1");
		
		if(currentSong != null){
			songNumber = currentSong.trackNumber;
			songSpeed = currentSong.trackSpeed;
			//currentAudio = (AudioClip)Resources.Load("Songs/Audio/Track " + songNumber);
			//audioPlayer.PlayOneShot(currentAudio);
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
	
	public void nextTrack(int specificSong = 0){
		if(specificSong != 0){
			songNumber = specificSong;
		} else {
			songNumber++;
		}
		currentSong = (Song)Resources.Load("Songs/Hard/Track " + songNumber);
		//currentAudio = (AudioClip)Resources.Load("Songs/Audio/Track " + songNumber);
		//audioPlayer.PlayOneShot(currentAudio);
		//Debug.Log("Searching in Songs/Hard/Track " + songNumber);
		songSpeed = currentSong.trackSpeed;
		spawnNotes(currentSong);
		noteReel.transform.position = reelStart;
		
		GameManager.trackNotesHit = 0;
		GameManager.trackTotalNotes = 0;
		GameManager.trackAccuracy = 0;
		GameManager.trackCurrentCombo = 0;
	}
	
	public static void playTrack(int trackNumber = 999){
		if(trackNumber != 999){
			songNumber = trackNumber;
		}
		AudioClip newAudio = (AudioClip)Resources.Load("Songs/Audio/Track " + songNumber);
		Debug.Log("Load audio track: " + newAudio);
		
		audioPlayerSt = GameObject.Find("Main Camera").GetComponent<AudioSource>();
		
		audioPlayerSt.PlayOneShot(newAudio);
	}
}
