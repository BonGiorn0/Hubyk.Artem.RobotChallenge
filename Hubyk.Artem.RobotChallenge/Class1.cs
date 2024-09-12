using Robot.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;

namespace Hubyk.Artem.RobotChallenge
{
    public class HubykAlgorithm : IRobotAlgorithm
    {
        string IRobotAlgorithm.Author
        {
            get{
                return "Hubyk Artem";
            } 
        }

        public RobotCommand DoStep(IList<Robot.Common.Robot> robots, int robotToMoveIndex, Map map)
        {
            var tmp = robots[robotToMoveIndex];
            
            return new MoveCommand() { NewPosition = new Position() { X = tmp.Position.X + 1, Y = tmp.Position.Y  + 1} };
        }

    }
}
