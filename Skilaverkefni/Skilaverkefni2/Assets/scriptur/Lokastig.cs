using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lokastig : MonoBehaviour//klasi
{
    public Text stig;//breyta fyrir stigin
    // Start is called before the first frame update
    void Start()
    {
        stig.text = "Stig: " + PlayerMovment.count.ToString();//segir hvernig á að prenta út 
    }

    
}
