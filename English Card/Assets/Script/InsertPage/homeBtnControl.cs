using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class homeBtnControl : MonoBehaviour {
    public Button homeBtn;
	// Use this for initialization
	void Start () {
        homeBtn.onClick.AddListener(homeBtnClick);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void homeBtnClick()
    {
        SceneManager.LoadScene("proj");
    }
}
