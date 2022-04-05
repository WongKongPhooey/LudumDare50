using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AttackLogic : MonoBehaviour
{
	
	public Transform stoatPos;
	public Transform player;

    public Transform spawn1;
    public Transform spawn2;
    public static int spawnCount = 0;

    public  bool enableAttacks;
    public static bool enableAttacksSt;

    public GameObject skull;
    public GameObject spawnMarker;
    public GameObject laser;
	public static Transform stoatPosSt;
	public static Transform playerSt;
    public static Transform spawn1St;
    public static Transform spawn2St;
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
        enableAttacksSt = enableAttacks;
        spawn1St = spawn1;
        spawn2St = spawn2;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
	
	public static void launchAttack(string attackName){
        if (enableAttacksSt == false) 
        {
            // dont do attacks in pracitce land
        }
        else { 
            //Debug.Log("Running statess");
		    switch(attackName){
			    case "Skull":
                    if (spawnCount == 0)
                    {
                        spawnCount++;
                        Instantiate(spawnMarkerSt, spawn1St.position, Quaternion.identity);
                        Instantiate(skullSt, spawn1St.position, Quaternion.identity);
                        Debug.Log("Launch Skull");
                        break;
                    }
                    else
                    {

                        spawnCount = 0;
                        Instantiate(spawnMarkerSt, spawn2St.position, Quaternion.identity);
                        Instantiate(skullSt, spawn2St.position, Quaternion.identity);
                        Debug.Log("Launch Skull");
                        break;
                    }
                    
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
}
