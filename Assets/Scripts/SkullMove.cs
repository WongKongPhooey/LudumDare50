using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkullMove : MonoBehaviour
{
	public GameObject player;

    // Start is called before the first frame update
    void Start(){
        player = GameObject.Find("CharacterSprite");
    }

    // Update is called once per frame
    void Update(){
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(player.transform.position.x, 0.7f,0),0.02f);
    }
	
	void OnTriggerEnter2D(Collider2D other) {
		//Debug.Log(other.name);
		if(other.name == "CharacterSprite"){
			Destroy(this.gameObject);
			if(GameManager.shieldOn == false){
				GameManager.health-=10;
			} else {
				GameManager.health-=1;
			}
		}
	}
}
