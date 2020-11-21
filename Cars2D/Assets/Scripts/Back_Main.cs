using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back_Main : MonoBehaviour
{
    public float speed; //Скорость движения фона
    public Transform firstback; //Нижний фон
    public Transform secondback;//Верхний фон
    public GameObject Topl; //Топливо
    public GameManager GameManager; //Менеджер игры
    // Start is called before the first frame update
    void Update()  //Обновление игры
    {
        if (GameManager.IsGamePause == false) //Игра не на паузе
        {
            if (firstback.position.y <= -11.158f) //Нижний фон
            {
                SwitchPos(firstback, Topl);

            }
            if (secondback.position.y <= -11.158f) //Верхний фон
            {
                SwitchPos(secondback, Topl);
            }
            transform.position += Vector3.down * speed * Time.deltaTime; //Движение фона
        }
    }
    void SwitchPos(Transform Back, GameObject Topl) //Движение фона и монетки(топлива) на место вверх
    {
        Topl.transform.position = new Vector3(Random.Range(-0.7f, 1.94f), Topl.transform.position.y, 0);
        Back.position = new Vector3(2.2f, 11.158f, 0);
       

    }
}
