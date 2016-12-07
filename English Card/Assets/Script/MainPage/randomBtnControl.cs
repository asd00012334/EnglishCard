using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class randomBtnControl : MonoBehaviour {
    public Button randBtn;
	// Use this for initialization
	void Start () {
        randBtn.onClick.AddListener(change2randomScene);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void change2randomScene()
    {
        SceneManager.LoadScene("random");
    }
}
