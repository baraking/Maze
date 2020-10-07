using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();

    }

    private void OnTriggerEnter(Collider other)
    {
        animator.Play("DoorOpenAnimation");
    }

    private void OnTriggerExit(Collider other)
    {
        animator.Play("DoorCloseAnimation");
    }
}
