using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
    private bool isDragging = false;
    private bool isOverDropArea = false;
    private GameObject dropArea;
    private Vector2 startPosition;
    public MonsterData monster;
    public EndTurn EndTurn;

    public int damage = 1;

    private void Start()
    {
        monster = FindObjectOfType<MonsterData>();
        EndTurn = FindObjectOfType<EndTurn>();
    }
    // Update is called once per frame
    void Update()
    {
        if (isDragging)
        {
            transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isOverDropArea = true;
        dropArea = collision.gameObject;
    }
    
    private void OnCollisionExit2D(Collision2D collision)
    {
        isOverDropArea = false;
        dropArea = null;
    }
    
    public void StartDrag()
    {
        startPosition = transform.position;
        isDragging = true;
    }

    public void EndDrag()
    {
        isDragging = false;
        if (isOverDropArea)
        {
            gameObject.SendMessage("CardEffect");
            Destroy(gameObject);
            if(monster.hp<=0)
            {
                EndTurn.YouWinBattle();
            }
        }
        else
        {
            transform.position = startPosition;
        }
    }
}
