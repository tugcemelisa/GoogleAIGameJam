using UnityEngine;

public class Movement : MonoBehaviour
{

    public float velocidad;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * velocidad, 0, Input.GetAxis("Vertical") * velocidad);
    }

}
