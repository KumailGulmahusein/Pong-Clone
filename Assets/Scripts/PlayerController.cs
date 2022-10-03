using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //speed of player
    public float speed = 10;

    //bounds of player
    public float topBound = 4.5F;
    public float bottomBound = -4.5F;

    void Start()
    {
        //Use this for initialization
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Pauses or resumes the game when player hits P
        if (Input.GetKeyDown(KeyCode.P) && Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
        else if (Input.GetKeyDown (KeyCode.P) && Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
    }
    void FixedUpdate()
    {
        //get player input and set speed
        float movementSpeedY = speed * Input.GetAxis("Vertical") * Time.deltaTime;
        transform.Translate(0, movementSpeedY, 0);

        //set the bounds of th eplayer
        if (transform.position.y > topBound)
        {
            transform.position = new Vector3(transform.position.x, topBound, 0);
        }
        else if (transform.position.y < bottomBound)
        {
            transform.position = new Vector3(transform.position.x,bottomBound, 0);
        }
    }
}
