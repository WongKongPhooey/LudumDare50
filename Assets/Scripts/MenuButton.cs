using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuButton : MonoBehaviour
{

    
    public Canvas c;
    public Canvas cTurnoff;
   // public GameObject logoHolder;
    public string SceneName;
    // Start is called before the first frame update
    void Start()
    {
   
    }



    public void ButtonFire()
    {
        Debug.Log("Testing");
    
        StartCoroutine(FadeOut()); // fade out old canvas
      
    }


    IEnumerator FadeOut()
    {

        for (int i = 0; i != 20; i++)
        {
            var alphaCurrent = cTurnoff.GetComponent<CanvasGroup>().alpha;
            Debug.Log("Fading");
            cTurnoff.GetComponent<CanvasGroup>().alpha = alphaCurrent - 0.05f;
            yield return new WaitForSeconds(0.01f);
        }

     
        c.enabled = true;
    }

    public void LoadNewScene()
    { 
        StartCoroutine(StartingScene());
    }


    // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode

    IEnumerator StartingScene()
    {
        
            yield return new WaitForSeconds(1.6f);
        
        //SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().name);
       // SceneManager.GetActiveScene.
       // SceneManager.UnloadSceneAsync(1);
        SceneManager.LoadScene(SceneName, LoadSceneMode.Single);
    }
}
