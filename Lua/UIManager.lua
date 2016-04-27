local UIManager = {}

function UIManager.Init()
    local ui = GameObject("UI")
    local canvas = ui:AddComponent(Canvas)
    canvas.renderMode = RenderMode.ScreenSpaceOverlay
    local canvasScaler = ui:AddComponent(CanvasScaler)
    canvasScaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize
    canvasScaler.referenceResolution = Vector2(960, 640)
    canvasScaler.screenMatchMode = CanvasScaler.ScreenMatchMode.MatchWidthOrHeight
    canvasScaler.matchWidthOrHeight = 1
end

return UIManager

