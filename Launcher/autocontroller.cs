using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;

public class autocontroller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(start_playing(3));

    }

    IEnumerator start_playing(float sec)
    {
        yield return new WaitForSeconds(sec);
        string build_path = Directory.GetCurrentDirectory();
        string pythonPath = build_path + @"\VTuber\launcher.bat";
        Process proc = Process.Start(pythonPath);
    }

}

