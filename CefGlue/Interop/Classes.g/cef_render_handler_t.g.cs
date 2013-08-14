//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue.Interop
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.InteropServices;
    using System.Security;
    
    [StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
    [SuppressMessage("Microsoft.Design", "CA1049:TypesThatOwnNativeResourcesShouldBeDisposable")]
    internal unsafe struct cef_render_handler_t
    {
        internal cef_base_t _base;
        internal IntPtr _get_root_screen_rect;
        internal IntPtr _get_view_rect;
        internal IntPtr _get_screen_point;
        internal IntPtr _get_screen_info;
        internal IntPtr _on_popup_show;
        internal IntPtr _on_popup_size;
        internal IntPtr _on_paint;
        internal IntPtr _on_cursor_change;
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int add_ref_delegate(cef_render_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int release_delegate(cef_render_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int get_refct_delegate(cef_render_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int get_root_screen_rect_delegate(cef_render_handler_t* self, cef_browser_t* browser, cef_rect_t* rect);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int get_view_rect_delegate(cef_render_handler_t* self, cef_browser_t* browser, cef_rect_t* rect);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int get_screen_point_delegate(cef_render_handler_t* self, cef_browser_t* browser, int viewX, int viewY, int* screenX, int* screenY);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int get_screen_info_delegate(cef_render_handler_t* self, cef_browser_t* browser, cef_screen_info_t* screen_info);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_popup_show_delegate(cef_render_handler_t* self, cef_browser_t* browser, int show);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_popup_size_delegate(cef_render_handler_t* self, cef_browser_t* browser, cef_rect_t* rect);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_paint_delegate(cef_render_handler_t* self, cef_browser_t* browser, CefPaintElementType type, UIntPtr dirtyRectsCount, cef_rect_t* dirtyRects, void* buffer, int width, int height);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_cursor_change_delegate(cef_render_handler_t* self, cef_browser_t* browser, IntPtr cursor);
        
        private static int _sizeof;
        
        static cef_render_handler_t()
        {
            _sizeof = Marshal.SizeOf(typeof(cef_render_handler_t));
        }
        
        internal static cef_render_handler_t* Alloc()
        {
            var ptr = (cef_render_handler_t*)Marshal.AllocHGlobal(_sizeof);
            *ptr = new cef_render_handler_t();
            ptr->_base._size = (UIntPtr)_sizeof;
            return ptr;
        }
        
        internal static void Free(cef_render_handler_t* ptr)
        {
            Marshal.FreeHGlobal((IntPtr)ptr);
        }
        
    }
}