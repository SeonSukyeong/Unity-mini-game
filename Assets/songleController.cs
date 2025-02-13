using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class songleController : MonoBehaviour
{
    public Rigidbody2D songBody;
    public float jumpPower;
    public logicManager logic;
    public bool songleAlive = true;

    AudioSource aud;
    public AudioClip audJump;
    public AudioClip audCollision;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicManager>();
        this.aud = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&songleAlive)
        {
            songBody.velocity = Vector2.up * jumpPower;
            this.aud.PlayOneShot(this.audJump);
            this.aud.volume = 0.5f;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        this.aud.PlayOneShot(this.audCollision);
        this.aud.volume = 0.5f;
        logic.gameOver();
        songleAlive = false;
    }
}
