using UnityEngine;
using System.Collections;

public class animController : MonoBehaviour
{
    public Animator anim;

    void Start () {
        anim = GetComponent<Animator>();
    }

    void Update () {
        if (Input.GetKeyDown("r"))
        {
            anim.Play("RevolverAnimation");
        }
    }
}
