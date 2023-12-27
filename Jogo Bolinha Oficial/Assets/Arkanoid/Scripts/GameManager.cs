 using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int vidas = 2;
    public int tilojosRestantes; 

    public GameObject platerprefab;
    public GameObject ballprefab;
    public Transform playerSpawnPos;
    public Transform ballSpwanPoint;

    public PlayerB playerAtual;
    public BallB ballAtaual;

    public TextMeshProUGUI contador;
    public TextMeshProUGUI msgFinal;

    public bool segurando; 
    private Vector3 offset;

    private void Awake()
    {
        instance = this;     
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void AtualizarContador()
    {
        contador.text = $"Vidas = {vidas}";
    }

    public void SpwanarNovoJogador()
    {
        GameObject playerObj = instantiate(playerprefab, playerSpawnPos.Position, Quartenion.identiny);
        GameObject ballObj = instantiate(ballprefab, ballSpwanPoint.Position, Quartenion.identiny);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
