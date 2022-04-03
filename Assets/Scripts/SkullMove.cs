using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkullMove : MonoBehaviour
{
	public GameObject player;
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(-7.7f, 0.7f,0), 0.2f);
    }
	
	void OnTriggerEnter2D(Collider2D other) {
		//Debug.Log(other.name);
		Destroy(this.gameObject);
	}
}
