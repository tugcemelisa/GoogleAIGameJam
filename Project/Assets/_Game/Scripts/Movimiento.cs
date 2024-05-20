using UnityEngine;

public class Movimento : MonoBehaviour
{

    public float velocidad;
    public GameObject prefabBala;
    public int numeroItems = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * velocidad, 0, Input.GetAxis("Vertical") * velocidad);
        transform.Rotate(0, Input.GetAxis("Mouse X"), 0);

        if (Input.GetButtonDown("Fire1"))
        {
            GameObject balaAuxiliar = Instantiate(prefabBala, transform.position + transform.forward * 2, Quaternion.identity);
            balaAuxiliar.GetComponent<Rigidbody>().AddForce(transform.forward * 100);
            Destroy(balaAuxiliar, 2);
        }


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Cube A")
        {
            Debug.Log("Hemos entrado al cubo A");
            //GetComponent<AudioSource>().Play();
        }

        if (other.tag == "Item")
        {
            // FindObjectOfType<Player>().ItemConseguido();
            Debug.Log("Hemos cogido un ítem");
            Destroy(other.gameObject);
            numeroItems++;
        }
    }




}
