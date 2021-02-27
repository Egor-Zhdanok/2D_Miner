using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class MySCRIPT: MonoBehaviour 
{
    public void PressedStartLvl( int sceneID )    
{
        SceneManager.LoadScene(sceneID);
    	}

    public void PressedExit()    
{
Debug.Log("Pressed");
        Application.Quit();
    	}

}
