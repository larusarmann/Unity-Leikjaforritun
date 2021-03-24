using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading;

public class PlayerMovment : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 20;//setur hraða
    public float sideways = 20;//hliðarhraði
    public float jump = 20;//hopp
    //private Rigidbody leikmadur;
    public static int count;//teljarinn
    public Text countText;//textinn

    void Start()
    {
        Debug.Log("byrja");//sendir í consolið
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        
        if (Input.GetKey("f"))//snýr player
        {
            transform.Rotate(new Vector3(0, 5, 0));
        }
        if (Input.GetKey("g"))//snýr player
        {
            transform.Rotate(new Vector3(0, -5, 0));
        }
        if (Input.GetKey(KeyCode.Space))//hoppa
        {
            transform.position += transform.up * jump ;
        }
        if (transform.position.y <= -1)
        {
            Endurræsa();
        }
        if (Input.GetKey(KeyCode.UpArrow))//áfram
        {
            transform.position += transform.forward * speed ;
        }
        if (Input.GetKey(KeyCode.DownArrow))// til baka
        {
            transform.position += -transform.forward * speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))//hægri
        {
            transform.position += transform.right * sideways;
        }
        if (Input.GetKey(KeyCode.LeftArrow))//vinstri
        {
            transform.position += -transform.right * sideways;
        }
        if (transform.position.y<=-1)//endurræsir ef player dettur af hliðinni
        {
            Endurræsa();
        }
    }
   
     void OnCollisionEnter(Collision collision)
    {
        // ef player keyrir á object sem heitir hlutur
        if (collision.collider.tag == "hlutur")
        {
            collision.collider.gameObject.SetActive(false);
            count = count + 1;//bætir í teljara
            SetCountText();//kallar á fallið
        }
        if (collision.collider.tag == "pikk")
        {
            collision.collider.gameObject.SetActive(false);
            count = count + 5;//bætir í teljara
            SetCountText();//kallar á fallið
        }
        if (collision.collider.tag == "hindrun")
        {
            collision.collider.gameObject.SetActive(false);
            count = count -1;//dregur frá teljara
            SetCountText();//kallar á fallið
        }
    }
    void SetCountText()
    {
        countText.text = "Stig: " + count.ToString();//segir hvað á að prenta

        if (count <= 0)//ef playerinn er með 0 eða minna klárast leikurinn
        {
            this.enabled = false;//kemur í veg fyrir að playerinn geti hreyfst áfram eftir dauðan
            SceneManager.LoadScene(3);//loadar GameOver senuni
            StartCoroutine(Bida());//biður

        }
        
    }
    IEnumerator Bida()
    {
        yield return new WaitForSeconds(1);//breyta
        Endurræsa();//endurræsir
    }
   
    public void Byrja()
    {
        SceneManager.LoadScene(1);//loadar fyrsta borði
    }
    public void Endurræsa()
    {
        SceneManager.LoadScene(0);//loadar byrjunarskjá
    }

}
