using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackLogic : MonoBehaviour
{
	
	public Transform stoatPos;
	public Transform player;
	
	public GameObject skull;
    public GameObject spawnMarker;
    public GameObject laser;
	public static Transform stoatPosSt;
	public static Transform playerSt;
	public static GameObject skullSt;
    public static GameObject spawnMarkerSt;
    public static GameObject laserSt;
	
    // Start is called before the first frame update
    void Start()
    {
		playerSt = player;
		skullSt = skull;
        spawnMarkerSt = spawnMarker;
        stoatPosSt = stoatPos;
		laserSt = laser;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public static void launchAttack(string attackName){
		switch(attackName){
			case "Skull":
                Instantiate(spawnMarkerSt, stoatPosSt.position, Quaternion.identity);
                Instantiate(skullSt, stoatPosSt.position , Quaternion.identity);
				Debug.Log("Launch Skull");
				break;
			case "Laser":
                Instantiate(laserSt, new Vector3(playerSt.position.x, 4.7f, 0f), Quaternion.identity);
                //laserSt.SetActive(true);
				//laserSt.transform.position = new Vector3(playerSt.position.x,4.7f,0f);
				Debug.Log("Launch Laser");
				break;
			case "Wave":
				//sendWave();
				Debug.Log("Launch Wave");
				break;
			default:
				//Do nothing
				break;
		}
	}
}
