using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BasicMenuButton : MonoBehaviour
{
    public string SceneName;
    // Start is called before the first frame update
    private void OnMouseOver()
    {


        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneName, LoadSceneMode.Single);
        }
    }

   
}
