using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackLogic : MonoBehaviour
{
	
	public Transform stoatPos;
	public GameObject skull;
	public static Transform stoatPosSt;
	public static GameObject skullSt;
	
    // Start is called before the first frame update
    void Start()
    {
		skullSt = skull;
		stoatPosSt = stoatPos;
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
				//fireLaser();
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
