using System;
using UnityEngine;
using FairyGUI;
using DG.Tweening;

public class RockingBar : EventDispatcher
{
    public EventListener onMove { get; private set; }
    public EventListener onEnd { get; private set; }

    private GButton rockingbarButton;
    private GObject thumb;
    private GObject touchArea;
    private GObject center;

    private float initX;
    private float initY;
    private int touchID;
    private int radius;
    private Tweener tweener;

    private MirDirection mirDirection;

    public RockingBar()
    {
    }

    public void SetRun(GComponent DoubleDJoystick)
    {
        Initialize(DoubleDJoystick, "joystick_2", "direct_2", "joystick_touch_2", "joystick_center_2");
    }

    public void SetWalk(GComponent DoubleDJoystick)
    {
        Initialize(DoubleDJoystick, "joystick_1", "direct_1", "joystick_touch_1", "joystick_center_1");
    }

    private void Initialize(GComponent DoubleDJoystick, string buttonName, string thumbName, string touchAreaName, string centerName)
    {
        onMove = new EventListener(this, "onMove");
        onEnd = new EventListener(this, "onEnd");

        rockingbarButton = DoubleDJoystick.GetChild(buttonName).asButton;
        rockingbarButton.changeStateOnClick = false;

        thumb = DoubleDJoystick.GetChild(thumbName);
        touchArea = DoubleDJoystick.GetChild(touchAreaName);
        center = DoubleDJoystick.GetChild(centerName);

        initX = center.x + center.width / 2;
        initY = center.y + center.height / 2;
        touchID = -1;
        radius = (int)(center.width / 2);

        touchArea.onTouchBegin.Add(OnTouchBegin);
        touchArea.onTouchMove.Add(OnTouchMove);
        touchArea.onTouchEnd.Add(OnTouchEnd);
    }

    private void OnTouchBegin(EventContext context)
    {
        if (touchID == -1)
        {
            InputEvent inputEvent = (InputEvent)context.data;
            touchID = inputEvent.touchId;

            // 获取触摸点的局部坐标
            Vector2 localPos = center.parent.GlobalToLocal(new Vector2(inputEvent.x, inputEvent.y));
            float posX = localPos.x;
            float posY = localPos.y;
            initX = posX;
            initY = posY;

            // 更新中心点位置
            center.SetXY(posX - center.width / 2, posY - center.height / 2);

            // 更新摇杆按钮位置
            localPos = rockingbarButton.parent.GlobalToLocal(new Vector2(inputEvent.x, inputEvent.y));
            posX = localPos.x;
            posY = localPos.y;
            rockingbarButton.SetXY(posX - rockingbarButton.width / 2, posY - rockingbarButton.height / 2);

            // 更新拇指位置
            localPos = thumb.parent.GlobalToLocal(new Vector2(inputEvent.x, inputEvent.y));
            posX = localPos.x;
            posY = localPos.y;
            thumb.SetXY(posX - thumb.width / 2 + rockingbarButton.width + 6, posY - thumb.height / 2 + rockingbarButton.height / 2 + 12);

            if (tweener != null)
            {
                tweener.Kill();
                tweener = null;
            }

            rockingbarButton.selected = true;

            context.CaptureTouch();
        }
    }

    private void OnTouchMove(EventContext context)
    {
        InputEvent inputEvent = (InputEvent)context.data;
        if (touchID != -1 && inputEvent.touchId == touchID)
        {
            // 使用中心的父节点进行局部坐标转换
            Vector2 localPos = center.parent.GlobalToLocal(new Vector2(inputEvent.x, inputEvent.y));
            float posX = localPos.x;
            float posY = localPos.y;

            float deltaX = posX - initX;
            float deltaY = posY - initY;

            float distance = Mathf.Sqrt(deltaX * deltaX + deltaY * deltaY);
            if (distance > radius)
            {
                posX = initX + (deltaX / distance) * radius;
                posY = initY + (deltaY / distance) * radius;
            }

            rockingbarButton.SetXY(posX - rockingbarButton.width / 2, posY - rockingbarButton.height / 2);

            float rad = Mathf.Atan2(deltaY, deltaX);
            float degree = rad * 180 / Mathf.PI;
            thumb.rotation = degree + 90;
            thumb.visible = true;

            if ((rad >= -Math.PI / 8 && rad < 0) || (rad >= 0 && rad < Math.PI / 8))
            {
                mirDirection = MirDirection.Right;
            }
            else if (rad >= Math.PI / 8 && rad < 3 * Math.PI / 8)
            {
                mirDirection = MirDirection.DownRight;
            }
            else if (rad >= 3 * Math.PI / 8 && rad < 5 * Math.PI / 8)
            {
                mirDirection = MirDirection.Down;
            }
            else if (rad >= 5 * Math.PI / 8 && rad < 7 * Math.PI / 8)
            {
                mirDirection = MirDirection.DownLeft;
            }
            else if ((rad >= 7 * Math.PI / 8 && rad < Math.PI) || (rad >= -Math.PI && rad < -7 * Math.PI / 8))
            {
                mirDirection = MirDirection.Left;
            }
            else if (rad >= -7 * Math.PI / 8 && rad < -5 * Math.PI / 8)
            {
                mirDirection = MirDirection.UpLeft;
            }
            else if (rad >= -5 * Math.PI / 8 && rad < -3 * Math.PI / 8)
            {
                mirDirection = MirDirection.Up;
            }
            else
            {
                mirDirection = MirDirection.UpRight;
            }

            onMove.Call(mirDirection);
        }
    }

    private void OnTouchEnd(EventContext context)
    {
        InputEvent inputEvent = (InputEvent)context.data;
        if (touchID != -1 && inputEvent.touchId == touchID)
        {
            touchID = -1;
            thumb.visible = false;
            rockingbarButton.TweenMove(new Vector2(initX - rockingbarButton.width / 2, initY - rockingbarButton.height / 2), 0.3f).OnComplete(() =>
            {
                tweener = null;
                rockingbarButton.selected = false;
                thumb.rotation = 0;
            });

            onEnd.Call();
        }
    }
}
