using UnityEngine;

namespace BehaviourTree.Scripts.Nodes.Decorator
{
    public class BTWaitDecorator : BTNode
    {
        public BTNode node;
        public float duration;
        float counter;

        public override NodeState Execute()
        {
            if (node == null)
            {
                return NodeState.Failure;
            }

            if (counter < duration)
            {
                counter += Time.deltaTime;
                return NodeState.Running;
            }

            counter = 0;
            return node.Execute();
        }
    }
}