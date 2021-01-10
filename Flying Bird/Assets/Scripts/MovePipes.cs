using UnityEngine;

public class MovePipes : MonoBehaviour
{
    public float pipeSpeed;

    private void Start()
    {
        Destroy(this.gameObject, 3);    //Destroy metodunun 2 parametreli versiyonu. Sondaki 2 kaç saniye sonra destroy edeceğini belirler
    }

    void Update()
    {
        transform.Translate(pipeSpeed * Time.deltaTime, 0, 0);
    }
}
