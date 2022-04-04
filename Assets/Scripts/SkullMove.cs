using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkullMove : MonoBehaviour
{
	public GameObject player;
    public float playerX;






    [SerializeField]
    float moveSpeed = 2f;

    [SerializeField]
    float frequency = 10f;

    [SerializeField]
    float magnitude = 0.5f;

    bool facingRight = true;

    Vector3 pos, localScale;

    // Use this for initialization
    void Start()
    {
        player = GameObject.Find("CharacterSprite");
        playerX = player.transform.position.x;

        pos = transform.position;

        localScale = transform.localScale;

    }

    // Update is called once per frame
    void Update()
    {
        // transform.position = Vector3.MoveTowards(transform.position, new Vector3(player.transform.position.x, 0.7f,0),0.02f);
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(playerX, 0.7f, 0), 0.02f);
        
        //CheckWhereToFace();

       // if (facingRight)
        //    MoveRight();
        //else
          // MoveLeft();
    }

    void CheckWhereToFace()
    {
        if (pos.x < -7f)
            facingRight = true;

        else if (pos.x > 7f)
            facingRight = false;

        if (((facingRight) && (localScale.x < 0)) || ((!facingRight) && (localScale.x > 0)))
            localScale.x *= -1;

        transform.localScale = localScale;

    }

    void MoveRight()
    {
        pos += transform.right * Time.deltaTime * moveSpeed;
        transform.position = pos + transform.up * Mathf.Sin(Time.time * frequency) * magnitude;
    }

    void MoveLeft()
    {
        pos -= transform.right * Time.deltaTime * moveSpeed;
        transform.position = pos + transform.up * Mathf.Sin(Time.time * frequency) * magnitude;
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
