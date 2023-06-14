using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    bool isTouchingGround = false;
    [SerializeField] ParticleSystem dustTrail;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isTouchingGround){
            dustTrail.Play();
        } else{
            dustTrail.Stop();
        }
    }

    void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Ground"){
            isTouchingGround = true;
        }
    }

    void OnCollisionExit2D(Collision2D other) {
        if(other.gameObject.tag == "Ground"){
            isTouchingGround = false;
        }
    }
}
