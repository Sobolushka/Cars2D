using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static int km;                               //Число километров
    public Text Kilometres;                             //Текстовое поле, где отображаются пройденные километры
    public static bool IsGamePause = true;              //Останов игры
    public GameObject StartPan;                         //Стартовая панель
    public Back_Main Back_Main;                         //Управление фоном

    public GameObject GamePan;                          //Панель игры
    public playerController player;                     //Контроллер игрока
    public Scrollbar Scrollbar;                         //Уровень топлива
     public GameObject GameOverPan;                     //Панель окончания игры

    void Start()
    {
        player.rb.simulated = false;                    //Игрок не двигается
        IsGamePause = true;                             //Игра на паузе
    }
    public void StartGame(GameObject Player1)
    {
        Player1.SetActive(true);                        //Включение нужной машины
        player.rb.simulated = true;                     //Включение игрока (Players)
        km = 0;                                         //Объявление километров до начала игры
        IsGamePause = false;                            //Отмена паузы
        StartPan.SetActive(false);                      //Отключение стартовой панели
        GamePan.SetActive(true);                        //Включение игровой панели
        Scrollbar.size = 1;                             //Максимльное значение топлива
    }
    private void FixedUpdate()
    {
        if (IsGamePause == false)                       //Если игра не на паузе, километры прибавляются и отображаются, топливо уменьшается
        {
            km++;
            Kilometres.text = km.ToString();
            Scrollbar.size -= 0.001f;
            if (km > 300)                               //Топливо на экране появляется при километрах больше 300
            {
                Back_Main.Topl.SetActive(true);
            }
            if(Scrollbar.size == 0f)                    //Если топливо закончилось, конец игры
            {
                GameOver();
            }
        }
    }
    public void GameOver()                              //Включение панели конца игры
    {
        player.rb.simulated = false;
        IsGamePause = true;
        GamePan.SetActive(false);
        GameOverPan.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
