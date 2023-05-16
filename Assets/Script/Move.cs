using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] Rigidbody _rigidBody;
    [SerializeField] float _front = 1.0f;
    [SerializeField] float _movenum = 0.1f;
    bool isStop = false;
    Transform _posbase;
    Vector3 _pos;

    void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
        _posbase = _rigidBody.transform;
        _pos = _posbase.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            _rigidBody.MovePosition(new Vector3(_movenum, 0.0f, 0.0f));

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _rigidBody.MovePosition(new Vector3(_movenum, 0.0f, 0.0f));
        }

        _posbase.position = _pos;

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