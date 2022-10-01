using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimaScript : MonoBehaviour
{
    public Transform SpawnPoint;
    public Transform SetPoint;

    private bool isSet = false;
    private float rate = 0;
    private Rigidbody RB;
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
        Reset();
        VelReset();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!isSet)
        {
            RB.AddForce((Vector3)(SetPoint.position - transform.position).normalized * 20);
            transform.position = Vector3.MoveTowards(transform.position, SetPoint.position, rate);
            if (Random.value > .985 && transform.position != SetPoint.position)
                RB.AddForce(new Vector3(Random.value*2-1, Random.value*2-1, Random.value*2-1).normalized * 500);
            if (transform.position == SetPoint.position && RB.velocity == Vector3.zero)
                isSet = true;
            if (rate < 1)
            rate += .0005f;
        }
    }

    public void Reset()
    {
        transform.position = SpawnPoint.position;
        isSet = false;
        rate = 0;
    }

    public void VelReset()
    {
        RB.AddForce(new Vector3(Random.Range(-1, 1), Random.Range(-1, 1), Random.Range(-1, 1)).normalized * 1000);
    }
}
