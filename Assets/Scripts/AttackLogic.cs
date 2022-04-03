using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackLogic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public static void launchAttack(string attackName){
		switch(attackName){
			case "Skull":
				break;
			case "Laser":
				break;
			case "Wave":
				break;
			default:
				break;
		}
		Debug.Log("FIRED " + attackName);
	}
}
