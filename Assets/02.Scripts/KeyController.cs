using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction;
using UnityEngine.XR.Interaction.Toolkit;

public class KeyController : MonoBehaviour
{
    public bool isRandom;

    [SerializeField] private float xOutRange;
    [SerializeField] private float yOutRange;
    [SerializeField] private float zOutRange;

    Vector3 initSpawnPos;
    [SerializeField] private float xSpawnRange;
    [SerializeField] private float ySpawnRange;
    [SerializeField] private float zSpawnRange;

    public Vector3 fixedSpawnPos = Vector3.zero;

    void Start()
    {
        if (isRandom == true)
        {
            InitSpawn();
        }
    }

    void InitSpawn()
    {
        float xPos = Random.Range(-xSpawnRange, xSpawnRange);
        float yPos = Random.Range(0, ySpawnRange);
        float zPos = Random.Range(-zSpawnRange, zSpawnRange);

        initSpawnPos = new Vector3(xPos, yPos, zPos);
        transform.position = initSpawnPos;
    }

    void Update()
    {
        //if (RangeChecker())
        //{
        //    TransformReset();
        //}
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("KeyBound"))
        {
            TransformReset();
        }
    }


    //bool RangeChecker()
    //{
    //    if (Mathf.Abs(transform.position.x) > xOutRange || Mathf.Abs(transform.position.y) > yOutRange || Mathf.Abs(transform.position.z) > zOutRange)
    //    {
    //        return true;
    //    }
    //    else
    //    {
    //        return false;
    //    }
    //}

    void TransformReset()
    {
        transform.position = initSpawnPos;
    }

}
