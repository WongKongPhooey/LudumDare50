using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackLogic : MonoBehaviour
{
	
	public Transform stoatPos;
	public Transform player;
	
	public GameObject skull;
	public GameObject laser;
	public static Transform stoatPosSt;
	public static Transform playerSt;
	public static GameObject skullSt;
	public static GameObject laserSt;
	
    // Start is called before the first frame update
    void Start()
    {
		playerSt = player;
		skullSt = skull;
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
				Instantiate(skullSt, stoatPosSt.position , Quaternion.identity);
				Debug.Log("Launch Skull");
				break;
			case "Laser":
				laserSt.SetActive(true);
				laserSt.transform.position = new Vector3(playerSt.position.x,4.7f,0f);
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
