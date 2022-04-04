using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerShowUI : MonoBehaviour
{
    // Start is called before the first frame update
    public Canvas canvasToActivate;
    
 
    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        StartCoroutine(FadeIn());
    }

    public void ButtonFire()
    {
        Debug.Log("Testing");

         // fade out old canvas

    }


    IEnumerator FadeIn()
    {
        canvasToActivate.enabled = true;

        for (int i = 0; i != 20; i++)
        {
            var alphaCurrent = canvasToActivate.GetComponent<CanvasGroup>().alpha;
            Debug.Log("Fading");
            canvasToActivate.GetComponent<CanvasGroup>().alpha = alphaCurrent + 0.05f;
            yield return new WaitForSeconds(0.01f);
        }


  
    }
}
