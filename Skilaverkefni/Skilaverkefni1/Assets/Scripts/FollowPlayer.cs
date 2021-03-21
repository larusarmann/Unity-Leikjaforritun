// Lárus Ármann Kjartansson - 19/mars/2021
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour// býr til klasa
{
    public GameObject player; //býr til playerinn
    private Vector3 viewOffset = new Vector3(0, 8, -12);// segir hve langt á bakvið myndavélin eigi að vera

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + viewOffset;// uppfærir það í hverju "frame"
    }
}
