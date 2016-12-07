using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.IO;

public class InOut : MonoBehaviour {
    public InputField engIn;
    public InputField manIn;
    public Button enterButton;
    // Use this for initialization
    void Start () {
       
        enterButton.onClick.AddListener(enterButtonOnclick);
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void enterButtonOnclick()
    {
        if (engIn.text.Length > 0 && manIn.text.Length > 0)
        {
            StreamWriter saveFile = File.AppendText(Application.persistentDataPath+"\\save.cmos");
            saveFile.Write(engIn.text + " " + manIn.text+'\n');
            engIn.text = "";
            manIn.text = "";
            saveFile.Close();
        }
    }
}
