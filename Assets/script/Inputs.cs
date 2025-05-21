using UnityEngine;

public class InputsController : MonoBehaviour
{
    [Header("Transform")]
    public Transform lancador;

    [Header("Hinges Joints")]
    public HingeJoint2D hjLeft;
    public HingeJoint2D hjRight;

    [Header("Spring Joint")]
    public SpringJoint2D spOfLancador;

    void Start()
    {
        lancador = GetComponent<Transform>();
        hjLeft = GetComponent<HingeJoint2D>();
        hjRight = GetComponent<HingeJoint2D>();
        spOfLancador = GetComponent<SpringJoint2D>();
    }

    void Update()
    {
        HandleInputs();
    }

    void HandleInputs()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            
        }
    }
}