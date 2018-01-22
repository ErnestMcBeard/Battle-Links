using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class TitleNavigation : MonoBehaviour {

   /// <summary>
   /// Load scene by name 
   /// </summary>
   /// <param name="SceneName"></param>
    public void LoadScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

	
}
