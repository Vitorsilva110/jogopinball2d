using UnityEngine;

public class TriggerSpawn : MonoBehaviour
{
    public GameObject objetoParaSpawnar;
    public Transform novaPosicao;
    public molaBehaviour Script;

    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("chao"))
        {
            SpawnarObjeto();
            print("Spawnou");
        }

        if (collision.gameObject.CompareTag("checker"))
        {
            Debug.Log("Colidiu com checker: " + collision.gameObject.name);

            GameObject ballObj = GameObject.FindWithTag("Player");
            if (ballObj != null)
            {
                
                Script.ballTransform = ballObj.transform;
                Script.ballRb = ballObj.GetComponent<Rigidbody2D>();
                Script.canLaunch = true; 
            }
        }
    }

    void SpawnarObjeto()
    {
        var newgo = Instantiate(objetoParaSpawnar, novaPosicao.position, Quaternion.identity);
        Destroy(objetoParaSpawnar.gameObject);
        newgo.name = "ball_0";
    }
}
