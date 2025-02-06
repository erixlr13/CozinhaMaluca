using System.Security.Cryptography;
using System.Security.Permissions;
using UnityEngine;

public class ControladorJogador : MonoBehaviour
{   
    public float taxaMovimentacao;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    
    }

    void Update()
    {
        float altX, altY;

        // Para cima e para baixo - mexe com Y
        if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < 470)
            altY = 60 * Time.deltaTime * taxaMovimentacao;
        else if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > 33)
            altY = -60 * Time.deltaTime * taxaMovimentacao;
        else
            altY = 0;

        // Para os lados - mexe com X
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > 32)
            altX = -60 * Time.deltaTime * taxaMovimentacao;
        else if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 926)
            altX = 60 * Time.deltaTime * taxaMovimentacao;
        else
            altX = 0;

        // Modificar posição:

        Vector3 novaPos = new Vector3(altX, altY, 0);
        transform.position += novaPos;
    }
}
