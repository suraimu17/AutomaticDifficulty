using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using Cysharp.Threading.Tasks;

namespace Manager
{
    public class EnemyPattern : MonoBehaviour
    {
        /*
        public enum GeneratePattern 
        {
            Tank,//タンク
            All,//全方位
            CharaInter,//一か所にいっぱい

        }*/

       /* public void GetPettern(int Pattern,GameObject[] enemyList,Transform[] generatePosList) 
        {
            switch (Pattern) {

                case  0://Tank
                    TankPattern(enemyList[1], enemyList[0], generatePos);
                    break;
                case 1:
                    //処理
                    break;
                case 2:
                    //処理
                    break;
                case 3:
                    //処理
                    break;
                case 4:
                    //処理
                    break;
                case 5:
                    //処理
                    break;

                default:
                    Debug.Log("Default");
                    break;

            }
        
        }

        public async UniTaskVoid TankPattern(GameObject TankEnemy, GameObject Enemy,Vector3 generatePos) //asyncにする
        {
            Instantiate(TankEnemy, generatePos, Quaternion.identity);

            for (int i = 0; i < 2; i++)
            {
                await UniTask.Delay(System.TimeSpan.FromSeconds(1.5f));
                Instantiate(Enemy, generatePos, Quaternion.identity);
            }

        }
        public void AllPattern(int generateEnemyNum)
        {

            for (int i = 0; i < 3; i++)
            {
                Instantiate(TankEnemy, generatePos, Quaternion.identity);
            }

        }*/
    }
}