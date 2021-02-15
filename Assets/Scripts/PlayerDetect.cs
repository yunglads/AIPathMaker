using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetect : MonoBehaviour
{
    private int steps = 0;
    [Tooltip("Amount of times AI needs to walk over a ground tile in order to change it to a path tile (Default is 3)")]
    public int stepsTilStage2Path = 3;
    [Tooltip("Amount of times AI needs to walk over a ground tile in order to change it to a path tile (Default is 6)")]
    public int stepsTilStage3Path = 6;

    public Material groundStage1;
    public Material groundStage2;
    public Material groundStage3;

    bool inTrigger = false;

    // Update is called once per frame
    void Update()
    {
        if (steps <= stepsTilStage2Path)
        {
            gameObject.GetComponent<Renderer>().material = groundStage1;
        }
        if (steps >= stepsTilStage2Path)
        {
            gameObject.GetComponent<Renderer>().material = groundStage2; 
        }
        if (steps >= stepsTilStage3Path)
        {
            gameObject.GetComponent<Renderer>().material = groundStage3;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            inTrigger = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player" && inTrigger)
        {
            steps++;
            inTrigger = false;
        }
    }
}
