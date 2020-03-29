using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Core
{

    public class EnemyMovement : MonoBehaviour
    {
        public List<EnemyMoves> moves;
        GameController controller;
        int currentMove = 0;
        bool executeNextMove = true;
        private void Start()
        {
            controller = GameController.instance;
        }
        void Update()
        {
            if (executeNextMove)
            {
                executeNextMove = false;
                if (moves[currentMove].angle == 0)
                {
                    StartCoroutine(Move(moves[currentMove].radius / moves[currentMove].duration * Time.fixedDeltaTime, Mathf.Abs(moves[currentMove].radius)));
                }
                else
                {
                    StartCoroutine(Move(transform.position - moves[currentMove].radius * transform.up, moves[currentMove].angle / moves[currentMove].duration * Time.fixedDeltaTime, Mathf.Abs(moves[currentMove].angle)));
                }
                currentMove++;
                if (currentMove >= moves.Count) currentMove = 0;
            }
        }
        IEnumerator Move(Vector3 point, float rotateAmount, float totalRotation)
        {
            while (totalRotation > 0)
            {
                while (controller.isPaused)
                {
                    yield return null;
                }
                totalRotation -= Mathf.Abs(rotateAmount);
                transform.RotateAround(point, Vector3.forward, rotateAmount);
                yield return null;
            }
            executeNextMove = true;
            yield return null;
        }
        IEnumerator Move(float distancePerFrame, float totalDistance)
        {
            while (totalDistance > 0)
            {
                while (controller.isPaused)
                {
                    yield return null;
                }
                totalDistance -= Mathf.Abs(distancePerFrame);
                transform.Translate(Vector3.left * distancePerFrame);
                yield return null;
            }
            executeNextMove = true;
            yield return null;
        }
    }

}