using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.Tilemaps;

public class TerrainGeneratorManeger : MonoBehaviour
{
    public float startPositionX, startPositionY;

    [SerializeField] TextAsset[] ChunksMap;
    string chunksMap;
    string[] linhas;
    char[] caracteres;

    public TileBase dirt;
    public Tilemap tileMap;

    void Start()
    {
        int number = Random.Range(0, ChunksMap.Length);
        var pos = new Vector3Int(0, 0, 0);


        chunksMap = ChunksMap[number].ToString();
        linhas = chunksMap.Split('\n');

        pos.y = (int)startPositionY;
        foreach (string linhas in linhas)
        {
            caracteres = linhas.ToCharArray();
            foreach (char letras in caracteres)
            {
                switch (letras)
                {
                    case '#':
                        Debug.Log("Pisos");
                        tileMap.SetTile(pos, dirt);
                        break;

                    case ' ':
                        Debug.Log("Vazio");
                        break;


                    case 'E':
                        Debug.Log("Inimigo");
                        tileMap.SetTile(pos, dirt);
                        break;


                    case 'H':
                        Debug.Log("Decoração");
                        break; 
                    
                    case '1':
                        Debug.Log("Loot");
                        break;
                }
                pos.x++;
            }
            pos.x = (int)startPositionX;
            pos.y--;
        }
    }
}

/*
 * pos.x = (int)2.5;
 * pos.y = (int)-4.5;
*/