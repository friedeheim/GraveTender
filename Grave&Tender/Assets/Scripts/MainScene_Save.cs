using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScene_Save : MonoBehaviour
    
{
    // Deine bestehenden Variablen und Logik

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}

