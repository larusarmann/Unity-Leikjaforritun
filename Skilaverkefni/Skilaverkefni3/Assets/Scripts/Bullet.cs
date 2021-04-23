using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
    public float speed=20f;
    public Rigidbody rb;
    public int damage = 5;
    public GameObject sprengjan;
    public static int count;//klasabreyta
    private Text countText;
    void Start()
    {
        rb.velocity = transform.forward * speed;
        countText = GameObject.Find("text1").GetComponent<Text>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.collider.tag=="hlutur")
        {
            collision.collider.gameObject.SetActive(false);
            count = count + 1;//bætir í teljara
            countText.text = "stig " + count.ToString();
        }

    }
    void Sprengja()
    {
        Instantiate(sprengjan, transform.position, transform.rotation);
    }
}
