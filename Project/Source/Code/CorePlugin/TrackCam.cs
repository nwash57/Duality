using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Duality;
using Duality.Components;
using OpenTK;
using OpenTK.Input;

namespace Project
{
    [Serializable]
    [RequiredComponent(typeof(Camera))]
    public class TrackCam : Component, ICmpUpdatable
    {
        void ICmpUpdatable.OnUpdate()
        {
            Camera trackCam = this.GameObj.Camera;
            Vector3 currentPos = this.GameObj.Transform.Pos;
            Vector3 targetPos = new Vector3(Player.playerX, Player.playerY, -500);

            Vector3 camDiff = (targetPos - currentPos);

            Vector3 camVelocity = camDiff * MathF.Pow(10.0f, -0.5f);

            trackCam.GameObj.Transform.MoveByAbs(camVelocity * Time.TimeMult);
        }
    }
}
