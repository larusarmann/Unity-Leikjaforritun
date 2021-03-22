using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerMovement : MonoBehaviour
{
    public float hradi = 10;
    public float hlidarhradi = 10;
    private Rigidbody leikmadur;
    private int count;
    public Text countText;
    public Vector3 jump;
    public float jumpForce = 2.0f;
    public bool isGrounded;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Byrja");
        leikmadur = GetComponent<Rigidbody>();

        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);

    }
    void OnCollisionStay()
    {
        isGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.forward * hradi;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += -transform.forward * hradi;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += transform.right * hlidarhradi;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += -transform.right * hlidarhradi;
        }
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }
        private void OnCollisionEnter(Collision collision)
        {
        if (collision.collider.tag == "hlutur") // ef player snertir tag = hlutur
        {
            collision.collider.gameObject.SetActive(false);
            count = count + 1; // teljarinn
            Debug.Log("Nú er ég komin með " + count); // skrifar í console stig
            SetCountText(); // kallar á fallið

        }
    }
    void SetCountText()
    {
        countText.text = "Stig: " + count.ToString();
        if (count >= 4)
            countText.text = "Þú hefur unnið með" + count.ToString() + " stigum";
            // endurræsa;
    }       

    public void Endurraesa()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene(0);
    }
}


