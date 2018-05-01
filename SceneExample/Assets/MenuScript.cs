using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour {

	public Image beach, mountan, exit;

	public void ClickedBeach()
	{
		SceneManager.LoadScene(1);
	}

	public void ClickMountain()
	{
		SceneManager.LoadScene(2);
	}
	public void ClickCity()
	{
		SceneManager.LoadScene(3);
	}

	public void ClickExit()
	{
		Application.Quit();
	}

	
}
