using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimelineTextReader : MonoBehaviour
{

    void Awake()
    {
        var files = Directory.GetFiles(Application.dataPath + "/Resources/Timeline/", "*.txt");
        files.ToList().ForEach(c =>
        {
            Debug.Log(c);
        });

        StreamReader sr = new StreamReader(Application.dataPath + "/Resources/Timeline/omega_delta_04_2.txt");
        try
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                if (!line.StartsWith("#"))
                {
                    Debug.Log(line);
                }
            }
        }
        catch (Exception e)
        {
            Debug.Log(e.Message);
        }
        sr.Close();
    }
}
