using System.Collections;
using UnityEngine;

public class SpawnPipes : MonoBehaviour
{
    public JumpBird birdScript;
    public GameObject pipes;
    public float height;
    public float time;

    void Start()
    {
        StartCoroutine(Spawn(time));
    }

    private IEnumerator Spawn(float time)
    {
        yield return new WaitForSeconds(time);

        while (!birdScript.isDead)
        {
            Instantiate(pipes, new Vector3(6, Random.Range(-height + 0.5f, height + 0.3f), 0), Quaternion.identity);      //Instantiate o obje türünden obje bir instance yani yeni bir
                                                                                                                          //örnek yaratmak için(pipes) kullanılır. Burada Quaternion.identity
            yield return new WaitForSeconds(time);                                                          //z ekseni için kullnıldı.
        }
    }
}
