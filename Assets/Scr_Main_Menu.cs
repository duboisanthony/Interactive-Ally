using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Scr_Main_Menu : MonoBehaviour {

	public void PlayGame ()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}

	public void QuitGame ()
	{
		Debug.Log ("QUIT");
		Application.Quit ();
	}
}
