using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using UnityEngine.UI;
//using UnityEngine.UI;
//using static listHeader;

public class listControl : MonoBehaviour {

    
    public Text engText;
    public Text chiText;
    public Button seeBtn;

    public int rand;
    public int boo2txt;
    // Use this for nitialization
    public Button nextBtn;
    void Start () {
        //loadFile("./save.cmos");
        boo2txt = 0;
        rand = 0;
        nextBtn.onClick.AddListener(random);
        UnityEngine.Random.InitState(System.Guid.NewGuid().GetHashCode());
        seeBtn.onClick.AddListener(showAnswer);
        //enterButton.onClick.AddListener(enterButtonOnclick);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    
    public void random()
    {
       
        
            rand = UnityEngine.Random.Range(0, listHeader.catche.num);
            boo2txt = UnityEngine.Random.Range(0, 2);
            if(boo2txt==1)
            {
            engText.text = listHeader.catche.data[rand].eng;
                chiText.text = "";
            }
            else
            {
                engText.text = "";
            chiText.text = listHeader.catche.data[rand].chi;
            }
        
        
    }



   
    void showAnswer()
    {
        if(boo2txt==1)
        {
            chiText.text = listHeader.catche.data[rand].chi;
        }
        else
        {
            engText.text = listHeader.catche.data[rand].eng;
        }
    }
}
