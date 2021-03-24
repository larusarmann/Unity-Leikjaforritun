using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerFollower : MonoBehaviour// bý til klasa
{
    // Start is called before the first frame update
    public Transform player;// breyta
    public Vector3 offset;// breayta
 

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;//segir hversu langt myndavélin á að vera bakvið playerinn
    }
  
}

