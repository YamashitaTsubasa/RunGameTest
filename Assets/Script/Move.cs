using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] Rigidbody _rigidBody;
    [SerializeField] float _front = 1.0f;
    bool isStop = false;

    void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(isStop);
        if (!isStop)
        {
            _rigidBody.AddForce(0.0f, 0.0f, _front, ForceMode.Impulse);
        }
        if (isStop)
        {
            _rigidBody.velocity = Vector3.zero;
        }
    }

    public void OnTriggerEnter(Collider trigger)
    {
        if (trigger.gameObject.tag == "Goal")
        {
            isStop = true;
        }
    }
}