using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Takki : MonoBehaviour//klasi
{
    public void Byrja()//breyta
    {
        SceneManager.LoadScene(1);//færir yfir í fyrsta borð leiksinss
    }
    public void Endir()//breyta
    {
        SceneManager.LoadScene(0);// færir yfir í byrjunarsenuna
        PlayerMovment.count = 0;//stoppar playerinn fra því að hreyfast
    }
    
}
