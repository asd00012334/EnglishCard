using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ExitButtonHandler : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
        Button exitButton=GetComponent<Button>();
        exitButton.onClick.AddListener(exitButtonOnclick);
	}
	
	// Update is called once per frame
	void Update () {
	}
    public void exitButtonOnclick()
    {
        Debug.Log("Exit Button");
        Application.Quit();
    }
}
