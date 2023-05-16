using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] Rigidbody _rigidBody;
    [SerializeField] float _front = 1.0f;
    [SerializeField] float _movenum = 0.1f;
    private bool isStop = false;
    private Transform _tra;
    private Vector3 _pos;

    void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
        _tra = this.gameObject.transform;
        
    }

    // Update is called once per frame
    void Update()
    {
        _pos = _tra.position;

        if (!isStop)
        {
            if (_pos.x <= 9.5f)
            {
                if (Input.GetKey(KeyCode.RightArrow))
                {
                    _rigidBody.AddForce(_movenum, 0.0f, 0.0f, ForceMode.Impulse);

                }
            }
            if (_pos.x >= -9.5f)
            {
                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    _rigidBody.AddForce(-_movenum, 0.0f, 0.0f, ForceMode.Impulse);
                }
            }
            
            _rigidBody.velocity = new Vector3(0.0f, 0.0f, _front);
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