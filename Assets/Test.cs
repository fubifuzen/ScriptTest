using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Boss
{
    private int hp = 100;
    private int power = 25;
    private int mp = 53;

    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        this.hp -= damage;
    }

    public void Magic()
    {
        this.mp -= 5;
        if (mp >= 5)
        {
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
        }
        else
        {
            Debug.Log("MPが足りないため、魔法が使えない。");
        }
    }
        }

public class Test : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        Boss lastboss = new Boss();
        lastboss.Attack();
        lastboss.Defence(30);
        for (int m = 0; m < 10; m++)
        {
            lastboss.Magic();
        }
        int[] array = new int[3];

        array[0] = 10;
        array[1] = 30;
        array[2] = 20;

        for (int i = 0; i < 3; i++) 
        {
            Debug.Log (array [i]);
        }
        for (int i = 2; i >= 0; i--)
        {
            Debug.Log (array [i]);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
