using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class DeleteButton : MonoBehaviour {

    // Use this for initialization
    public Button deleteButton;
	void Start () {
        deleteButton.onClick.AddListener(deleteButtonOnclick);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void deleteButtonOnclick()
    {
        SceneManager.LoadScene("deleteScene");
    }
}
