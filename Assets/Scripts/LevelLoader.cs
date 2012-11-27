using UnityEngine;
using System.Collections;

public class LevelLoader : MonoBehaviour {
		
	private int toolbarInt = 0;
	private int levelCount = 0;
	
	// Make this game object and all its transform children
	// survive when loading a new scene.
	void Awake () {
		DontDestroyOnLoad (transform.gameObject);
		levelCount = Application.levelCount -1;
	}

	void OnGUI () {
		string[] toolbarStrings = new string[levelCount];
		for(int i=0; i<levelCount; i++)
		{
			toolbarStrings[i] = "Level " + (i+1);
		}
		toolbarInt = GUI.Toolbar (new Rect (25, 25, 250, 30), toolbarInt, toolbarStrings);
		
		if (toolbarInt +1 != Application.loadedLevel)
		{
			Application.LoadLevel(toolbarInt +1);
		}
	}
}
