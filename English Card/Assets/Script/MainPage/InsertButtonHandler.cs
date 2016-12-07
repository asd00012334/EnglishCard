using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class InsertButtonHandler : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Button insertButton = GetComponent<Button>();
        insertButton.onClick.AddListener(insertButtonOnclick);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void insertButtonOnclick()
    {
        Debug.Log("Insert Button Onclick");
        // Application.LoadLevel("insertScene");
        SceneManager.LoadScene("insertScene");
    }
}
