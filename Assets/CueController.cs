using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CueController : MonoBehaviour
{
    public GameObject cueBall;
    public GameObject triangle;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void HitBall()
    {
        ApplyForces();
    }
    public void HideTriangle()
    {
        triangle.active = false;
    }

    private void ApplyForces(){
        cueBall.GetComponent<Rigidbody>().AddForce(Vector3.forward * Time.deltaTime * 10, ForceMode.Impulse);
        Debug.log("Helloo from yaman ^_^");
        cueBall.GetComponent<Rigidbody>().AddForce(Vector3.right * Time.deltaTime * 2, ForceMode.Impulse);
    }
}
