using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class PedestalController : MonoBehaviour
{
    public GameObject pedestal;

    SphereCollider sphereCollider;

    Material keyMat;
    Material pedestalMat;

    XRSocketInteractor socket;

    private void OnEnable()
    {
        sphereCollider = GetComponent<SphereCollider>();
        pedestalMat = pedestal.GetComponent<MeshRenderer>().material;
        socket = GetComponent<XRSocketInteractor>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        keyMat = collision.gameObject.GetComponent<MeshRenderer>().material;

        if (keyMat == pedestalMat)
        {
            socket.socketActive = true;
            //sphereCollider.isTrigger = true;
        }
        else
        {
            socket.socketActive = false;
            //sphereCollider.isTrigger = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
