using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door_Koridor : MonoBehaviour {
	private bool inZone = false;
	private void OnTriggerEnter2D( Collider2D collision)	{
		inZone = true;
		Debug.Log("ОТОШЁЛ ОТ ДВЕРИ");
	}
	private void OnTriggerExit2D ( Collider2D collision )	{
		inZone = false;
		Debug.Log("И НЕ ПОДХОДИ БОЛЬШЕ К ДВЕРИ");
	}

	public int scene;
	void Update() {
		if (Input.GetKeyDown("space") && inZone)
        	{
            	print("space key was pressed");
            	SceneManager.LoadScene(scene);
        	}
    
      }
}
