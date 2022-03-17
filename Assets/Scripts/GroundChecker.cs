using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    Player _player;
    
    void Awake()
    {
        _player = GameObject.Find("Mario").GetComponent<Player>();
    }

    // Update is called once per frame
    void OnTriggerStay2D(Collider2D col)
    {
        _player.isGrounded = true;
    }
    void OnTriggerExit2D(Collider2D col)
    {
        _player.isGrounded = false;
    }
}
