using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBlast : MonoBehaviour
{
    bool killTime = false;
    bool overlapping = false;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitForKill());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (killTime == true && overlapping == true)
        {
           
            if (GameManager.shieldOn == false)
            {
                GameManager.health -= 10;
            }
            else
            {
                GameManager.health -= 1;
            }
            Destroy(this.gameObject);
        }
    }

    IEnumerator WaitForKill()
    {
        yield return new WaitForSeconds(1);
        killTime = true;
        yield return new WaitForSeconds(0.2f);
        killTime = false;
    }

    void OnTriggerEnter2D(Collider2D other) {
         overlapping = true;
        Debug.Log("Overlapping");
	}
    void OnTriggerExit2D(Collider2D other)
    {
        overlapping = false;
        Debug.Log("Leave Overlap Zone");
    }
}
