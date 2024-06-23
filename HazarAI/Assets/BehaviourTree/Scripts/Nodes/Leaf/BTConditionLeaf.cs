namespace BehaviourTree.Scripts.Nodes.Leaf
{
    public interface IBTCondition
    {
        bool Check();
    }

    public class BTConditionLeaf : BTNode
    {
        public IBTCondition condition;

        public override NodeState Execute()
        {
            if (condition.Check())
            {
                nodeState = NodeState.Success;
                return nodeState;
            }

            nodeState = NodeState.Failure;
            return nodeState;
        }
    }
}