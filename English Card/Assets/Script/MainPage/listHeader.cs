using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;


public  class listHeader : MonoBehaviour {
    public static DataList catche;
	// Use this for initialization
	void Start () {
        catche = new DataList(Application.persistentDataPath+"\\save.cmos");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public class strPair
    {
        public string eng;
        public string chi;
       
        public strPair(string english, string chinese)
        {
            eng = english;
            chi = chinese;
        }
    }





    public class DataList
    {
        public int num;
        public bool isLoad;
        public List<strPair> data;
        public DataList(string name)
        {
            isLoad = true;
            data = new List<strPair>();
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(name);

            }
            catch (Exception e)
            {
                Debug.Log("can't find file to read");
                return;
            }

            string line;
            //int num = 0;
            while ((line = sr.ReadLine()) != null)
            {
                num++;
                //lines.Add(line);
                convertLine2Strings(line);
            }

            sr.Close();
            sr.Dispose();
        }


        

        void convertLine2Strings(string line)
        {
            int i;
            string first = "";
            for (i = 0; i < line.Length; i++)
            {
                if (line[i] != ' ')
                {
                    first += line[i];
                }
                else
                {
                    break;
                }
            }
            string second = "";
            for (i = i + 1; i < line.Length; i++)
            {
                second += line[i];
            }
            
            data.Add(new strPair(first, second));
        }

    }
}
