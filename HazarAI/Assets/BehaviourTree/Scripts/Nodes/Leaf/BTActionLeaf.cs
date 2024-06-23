using System;

namespace BehaviourTree.Scripts.Nodes.Leaf
{
    public class BTActionLeaf : BTNode
    {
        public Func<NodeState> btAction;

        public override NodeState Execute()
        {
            return btAction.Invoke();
        }
    }
}