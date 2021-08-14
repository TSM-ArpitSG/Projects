using UnityEngine;
using System.Collections;

public class ApplicationManager : MonoBehaviour {
	

	public void Quit () 
	{
		Application.Quit();
		#if UNITY_EDITOR
		
		UnityEditor.EditorApplication.isPlaying = false;
		
		#endif
	}
}
