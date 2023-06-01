using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public GameObject player;
    [Range(5.0f,50.0f)]
    public float speed = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move() {
        if(Input.GetKey(KeyCode.W)){
            player.transform.position = new Vector3(player.transform.position.x,player.transform.position.y + (speed * Time.deltaTime),player.transform.position.z);
        }
        else if(Input.GetKey(KeyCode.S)){
            player.transform.position = new Vector3(player.transform.position.x,player.transform.position.y - (speed * Time.deltaTime),player.transform.position.z);
        }
        if(Input.GetKey(KeyCode.D)){
            player.transform.position = new Vector3(player.transform.position.x + (speed * Time.deltaTime),player.transform.position.y,player.transform.position.z);
        }
        else if(Input.GetKey(KeyCode.A)){
            player.transform.position = new Vector3(player.transform.position.x - (speed * Time.deltaTime),player.transform.position.y,player.transform.position.z);
        }
    }

}
