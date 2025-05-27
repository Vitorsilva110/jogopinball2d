using UnityEngine;

public class TriggerSpawn : MonoBehaviour
{
    public GameObject objetoParaSpawnar; 
    public Transform novaPosicao;        

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("chao"))
        {
            SpawnarObjeto();
            print("Spawnou");
        }
    }

    void SpawnarObjeto()
    {
        var newgo = Instantiate(objetoParaSpawnar, novaPosicao.position, Quaternion.identity);
        Destroy(objetoParaSpawnar.gameObject);
        newgo.name = "ball_0";
    }
}
