using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class deleteScript : MonoBehaviour {
    public Dropdown dropList;
    static List<string> appear;
    List<int> arr;
    // Use this for initialization
    void Start() {
        appear = new List<string>();
        arr = new List<int>();
        loadAppear();
        dropList.ClearOptions();
        dropList.AddOptions(appear);
        //listHeader.cache.data;
    }

    void loadAppear()
    {
        appear.Clear();
        for (int cnt = 0; cnt < listHeader.catche.num; cnt++)
        {
            appear.Add(
                listHeader.catche.data[cnt].eng + " " +
                listHeader.catche.data[cnt].chi
                );
            arr.Add(cnt);
        }
    }

    // Update is called once per frame
    void Update() {

    }

    public void deleteButtonOnclick()
    {
        try
        {
            int idx = dropList.value;
            appear.RemoveAt(idx);
            arr.RemoveAt(idx);
            listHeader.catche.data.RemoveAt(idx);
            //appear.Remove(appear[idx]);
            //listHeader.catche.data.Remove(listHeader.catche.data[idx]);
            listHeader.catche.num--;
            dropList.ClearOptions();
            dropList.AddOptions(appear);
        }
        catch (Exception)
        {
            Debug.Log("No more to delete");
        }
    }

    public void homeButtonOnclick()
    {
        //loadAppear();
        StreamWriter fout = new StreamWriter(Application.persistentDataPath+"\\save.cmos");
        for(int cnt=0;cnt<listHeader.catche.num;cnt++)
        {
            fout.WriteLine(appear[cnt]);
        }
        fout.Close();
        SceneManager.LoadScene("proj");
    }
}
