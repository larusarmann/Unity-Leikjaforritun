using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Skipti : MonoBehaviour//klasi
{
    void Start()
    {
        Debug.Log("byrja");//sendir í consolið "byrja"
    }
    private void OnTriggerEnter(Collider other)//breyta
    {
        other.gameObject.SetActive(false);
        StartCoroutine(Bida());//kallar í breytuna
    }
    IEnumerator Bida()//breyta
    {
        yield return new WaitForSeconds(3);//bíður 3 sek
        Endurræsa();
    }
    public void Endurræsa()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);//næsta sena
    }

}
