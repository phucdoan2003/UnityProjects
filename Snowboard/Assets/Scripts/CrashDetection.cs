using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetection : MonoBehaviour
{
    [SerializeField] float delayTime = 2f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSfx;
    bool crashed = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Ground"){
            FindObjectOfType<PlayerController>().DisableControls();
            if(!crashed){
                crashTrigger();
            }
            Invoke("reloadScene", delayTime);
        }
    }

    void crashTrigger(){
        crashEffect.Play();
        GetComponent<AudioSource>().PlayOneShot(crashSfx);
        crashed = true;
    }

    void reloadScene(){
        SceneManager.LoadScene(0);
    }
}
