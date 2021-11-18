using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;


public class MenuController : MonoBehaviour
{
	[Header("Levels To Load")]
	public string _newGameLevel;
	private string levelLoad; 

	public void NewGameYes()
	{
		SceneManager.LoadScene(_newGameLevel);
	}

   	public void ExitButton () 
   	{
   		Application.Quit();
   	}
}
