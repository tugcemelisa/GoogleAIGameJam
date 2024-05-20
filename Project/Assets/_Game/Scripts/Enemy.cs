using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{

    public int vida = 3;


    GameObject jugador;


    // Start is called before the first frame update
    void Start()
    {

        jugador = GameObject.Find("Player");

    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(jugador.transform);
        GetComponent<Rigidbody>().velocity = transform.forward * 2;
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Player")
        {
            Debug.Log("Nos ha golpeado");
            SceneManager.LoadScene(0);
        }
        if (collision.collider.tag == "Bala")
        {
            Destroy(collision.collider.gameObject);
            vida = vida - 1;
            if (vida == 0)
                Destroy(gameObject);
        }
    }
}
