//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2015 Stefanos Apostolopoulos for the Open Toolkit Library
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Text;
using System.Runtime.InteropServices;

namespace OpenTK.Graphics.ES20
{
    public sealed partial class GL
    {
        /// <summary>
        /// Contains native bindings to functions in the category "ShaderPixelLocalStorage2" in the extension "Ext".
        /// </summary>
        public static partial class Ext
        {
            /// <summary>
            /// [requires: EXT_shader_pixel_local_storage2]
            /// </summary>
            /// <param name="offset">
            /// </param>
            /// <param name="n">
            /// </param>
            /// <param name="values">
            /// [length: n]
            /// </param>
            [AutoGenerated(Category = "EXT_shader_pixel_local_storage2", Version = "", EntryPoint = "glClearPixelLocalStorageuiEXT")]
            public static void ClearPixelLocalStorage(int offset, int n, [CountAttribute(Parameter = "n")] uint[] values)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_shader_pixel_local_storage2]
            /// </summary>
            /// <param name="offset">
            /// </param>
            /// <param name="n">
            /// </param>
            /// <param name="values">
            /// [length: n]
            /// </param>
            [AutoGenerated(Category = "EXT_shader_pixel_local_storage2", Version = "", EntryPoint = "glClearPixelLocalStorageuiEXT")]
            public static void ClearPixelLocalStorage(int offset, int n, [CountAttribute(Parameter = "n")] ref uint values)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_shader_pixel_local_storage2]
            /// </summary>
            /// <param name="offset">
            /// </param>
            /// <param name="n">
            /// </param>
            /// <param name="values">
            /// [length: n]
            /// </param>
            [AutoGenerated(Category = "EXT_shader_pixel_local_storage2", Version = "", EntryPoint = "glClearPixelLocalStorageuiEXT")]
            public static unsafe void ClearPixelLocalStorage(int offset, int n, [CountAttribute(Parameter = "n")] uint* values)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_shader_pixel_local_storage2]
            /// </summary>
            /// <param name="target">
            /// </param>
            /// <param name="size">
            /// </param>
            [AutoGenerated(Category = "EXT_shader_pixel_local_storage2", Version = "", EntryPoint = "glFramebufferPixelLocalStorageSizeEXT")]
            public static void FramebufferPixelLocalStorageSize(uint target, int size)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_shader_pixel_local_storage2]
            /// </summary>
            /// <param name="target">
            /// </param>
            [AutoGenerated(Category = "EXT_shader_pixel_local_storage2", Version = "", EntryPoint = "glGetFramebufferPixelLocalStorageSizeEXT")]
            public static int GetFramebufferPixelLocalStorageSize(OpenTK.Graphics.ES20.FramebufferTarget target)
            {
                throw new BindingsNotRewrittenException();
            }

            [Slot(48)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glClearPixelLocalStorageuiEXT(int offset, int n, [CountAttribute(Parameter = "n")] uint* values);

            [Slot(180)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glFramebufferPixelLocalStorageSizeEXT(uint target, int size);

            [Slot(226)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern int glGetFramebufferPixelLocalStorageSizeEXT(OpenTK.Graphics.ES20.FramebufferTarget target);
        }
    }
}