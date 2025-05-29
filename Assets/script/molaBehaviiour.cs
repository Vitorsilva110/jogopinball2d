using UnityEngine;

public class molaBehaviour : MonoBehaviour
{
    public Transform molaTransform;
    public float maxPullDistance = 1f;
    public float launchForce = 500f;

    [HideInInspector] public Transform ballTransform;
    [HideInInspector] public Rigidbody2D ballRb;

    public Vector3 initialPosition;
    public bool isPulling = false;
    public bool canLaunch = false;

    void Start()
    {
        initialPosition = molaTransform.localPosition;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            isPulling = true;
            molaTransform.localPosition = Vector3.Lerp(
                molaTransform.localPosition,
                initialPosition - Vector3.up * maxPullDistance,
                Time.deltaTime * 10f
            );
        }

        if (Input.GetKeyUp(KeyCode.DownArrow) && isPulling && canLaunch && ballRb != null)
        {
            isPulling = false;
            canLaunch = false; 
            molaTransform.localPosition = initialPosition;
            ballRb.AddForce(Vector2.up * launchForce);
        }
    }
}
