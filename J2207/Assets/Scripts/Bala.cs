using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    Animator anim;
    [SerializeField] float speed;

    void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
    }

    private void OnTriggerEnter2D(Collider2D collison)
    {
        Destroy(gameObject);
    }
}
