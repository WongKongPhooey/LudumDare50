using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Song", menuName = "Song")]
public class Song : ScriptableObject
{
    public int trackNumber;
	public string trackName;
	public int trackLength;
	public int trackSpeed;
	
	public List<int> notes = new List<int>();
	public List<int> keys = new List<int>();
	public List<string> attacks = new List<string>();
}
