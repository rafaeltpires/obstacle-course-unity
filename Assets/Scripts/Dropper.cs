using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer mRenderer;
    Rigidbody rbody;
    [SerializeField] float timeToWait = 3f;

    // Start is called before the first frame update
    void Start()
    {
        mRenderer = GetComponent<MeshRenderer>();
        rbody = GetComponent<Rigidbody>();

        mRenderer.enabled = false;
        rbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {   
            mRenderer.enabled = true;
            rbody.useGravity = true;   
        }
        
    }
}
