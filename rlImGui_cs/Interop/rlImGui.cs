using System.Numerics;
using System.Runtime.InteropServices;
using ZeroElectric.Vinculum;

namespace rlImGui_cs;

public static unsafe partial class rlImGui
{
    [DllImport("rlImGui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rlImGuiSetup", ExactSpelling = true)]
    public static extern void Setup([NativeTypeName("_Bool")] bool darkTheme);

    [DllImport("rlImGui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rlImGuiBegin", ExactSpelling = true)]
    public static extern void Begin();

    [DllImport("rlImGui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rlImGuiEnd", ExactSpelling = true)]
    public static extern void End();

    [DllImport("rlImGui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rlImGuiShutdown", ExactSpelling = true)]
    public static extern void Shutdown();

    [DllImport("rlImGui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rlImGuiBeginInitImGui", ExactSpelling = true)]
    public static extern void BeginInitImGui();

    [DllImport("rlImGui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rlImGuiEndInitImGui", ExactSpelling = true)]
    public static extern void EndInitImGui();

    [DllImport("rlImGui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rlImGuiReloadFonts", ExactSpelling = true)]
    public static extern void ReloadFonts();

    [DllImport("rlImGui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rlImGuiBeginDelta", ExactSpelling = true)]
    public static extern void BeginDelta(float deltaTime);

    [DllImport("rlImGui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rlImGuiImage", ExactSpelling = true)]
    public static extern void Image([NativeTypeName("const Texture *")] Texture* image);

    [DllImport("rlImGui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rlImGuiImageSize", ExactSpelling = true)]
    public static extern void ImageSize([NativeTypeName("const Texture *")] Texture* image, int width, int height);

    [DllImport("rlImGui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rlImGuiImageSizeV", ExactSpelling = true)]
    public static extern void ImageSizeV([NativeTypeName("const Texture *")] Texture* image, Vector2 size);

    [DllImport("rlImGui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rlImGuiImageRect", ExactSpelling = true)]
    public static extern void ImageRect([NativeTypeName("const Texture *")] Texture* image, int destWidth, int destHeight, Rectangle sourceRect);

    [DllImport("rlImGui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rlImGuiImageRenderTexture", ExactSpelling = true)]
    public static extern void ImageRenderTexture([NativeTypeName("const RenderTexture *")] RenderTexture* image);

    [DllImport("rlImGui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rlImGuiImageRenderTextureFit", ExactSpelling = true)]
    public static extern void ImageRenderTextureFit([NativeTypeName("const RenderTexture *")] RenderTexture* image, [NativeTypeName("_Bool")] bool center);

    [DllImport("rlImGui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rlImGuiImageButton", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern bool ImageButton([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const Texture *")] Texture* image);

    [DllImport("rlImGui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "rlImGuiImageButtonSize", ExactSpelling = true)]
    [return: NativeTypeName("_Bool")]
    public static extern bool ImageButtonSize([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const Texture *")] Texture* image, [NativeTypeName("struct ImVec2")] Vector2 size);
}
