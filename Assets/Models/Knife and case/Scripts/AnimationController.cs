using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown("f"))
            anim.Play("Open case");
        if (Input.GetKeyDown("c"))
            anim.Play("Close case");
    }
}
