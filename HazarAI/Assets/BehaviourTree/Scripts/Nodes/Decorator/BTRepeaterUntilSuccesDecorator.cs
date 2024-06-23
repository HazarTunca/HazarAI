namespace BehaviourTree.Scripts.Nodes.Decorator
{
    public class BTRepeaterUntilSuccesDecorator : BTNode
    {
        public BTNode node;
        
        public override NodeState Execute()
        {
            switch (node.Execute())
            {
                case NodeState.Running:
                    nodeState = NodeState.Running;
                    return nodeState;
                
                case NodeState.Success:
                    nodeState = NodeState.Success;
                    return nodeState;
                
                case NodeState.Failure:
                default:
                    nodeState = NodeState.Running;
                    return nodeState;
            }
        }
    }
}