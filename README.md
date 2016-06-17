# UnityTricksAndCodeSpippet

1.在GUI绘制贝塞尔曲线：
  public static void DrawBezierBy2Points(Vector2 startPoint, Vector2 endPoint)
    {
        Vector3 startTangent = new Vector2(startPoint.x, (startPoint.y + endPoint.y) * 0.5f);
        Vector3 endTangent = new Vector2(endPoint.x, (startPoint.y + endPoint.y) * 0.5f);
        
        Color color = Color.white;
        UnityEditor.Handles.DrawBezier(startPoint, endPoint, startTangent, endTangent, color, null, 3);

    }
