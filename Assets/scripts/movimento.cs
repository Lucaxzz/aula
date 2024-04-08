using UnityEngine;

public class movimento : MonoBehaviour
{
    public float speed = 5f;  // Velocidade de movimento do personagem

    void Update()
    {
        float moveInput = Input.GetAxis("Horizontal");  // Obtém a entrada do teclado (setas esquerda/direita ou A/D)

        // Calcula o movimento horizontal multiplicando a entrada pelo speed
        float moveHorizontal = moveInput * speed * Time.deltaTime;

        // Atualiza a posição do personagem
        transform.Translate(new Vector3(moveHorizontal, 0, 0));
    }
}