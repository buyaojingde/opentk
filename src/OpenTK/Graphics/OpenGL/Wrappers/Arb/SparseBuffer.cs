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

namespace OpenTK.Graphics.OpenGL
{
    public sealed partial class GL
    {
        /// <summary>
        /// Contains native bindings to functions in the category "SparseBuffer" in the extension "Arb".
        /// </summary>
        public static partial class Arb
        {
            /// <summary>
            /// [requires: ARB_sparse_buffer]
            /// </summary>
            /// <param name="target">
            /// </param>
            /// <param name="offset">
            /// </param>
            /// <param name="size">
            /// </param>
            /// <param name="commit">
            /// </param>
            [AutoGenerated(Category = "ARB_sparse_buffer", Version = "", EntryPoint = "glBufferPageCommitmentARB")]
            public static void BufferPageCommitment(OpenTK.Graphics.OpenGL.BufferTargetArb target, IntPtr offset, int size, bool commit)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_sparse_buffer]
            /// </summary>
            /// <param name="target">
            /// </param>
            /// <param name="offset">
            /// </param>
            /// <param name="size">
            /// </param>
            /// <param name="commit">
            /// </param>
            [AutoGenerated(Category = "ARB_sparse_buffer", Version = "", EntryPoint = "glBufferPageCommitmentARB")]
            public static void BufferPageCommitment(OpenTK.Graphics.OpenGL.BufferTargetArb target, IntPtr offset, IntPtr size, bool commit)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_sparse_buffer]
            /// </summary>
            /// <param name="buffer">
            /// </param>
            /// <param name="offset">
            /// </param>
            /// <param name="size">
            /// </param>
            /// <param name="commit">
            /// </param>
            [AutoGenerated(Category = "ARB_sparse_buffer", Version = "", EntryPoint = "glNamedBufferPageCommitmentARB")]
            public static void NamedBufferPageCommitment(uint buffer, IntPtr offset, int size, bool commit)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_sparse_buffer]
            /// </summary>
            /// <param name="buffer">
            /// </param>
            /// <param name="offset">
            /// </param>
            /// <param name="size">
            /// </param>
            /// <param name="commit">
            /// </param>
            [AutoGenerated(Category = "ARB_sparse_buffer", Version = "", EntryPoint = "glNamedBufferPageCommitmentARB")]
            public static void NamedBufferPageCommitment(uint buffer, IntPtr offset, IntPtr size, bool commit)
            {
                throw new BindingsNotRewrittenException();
            }

            [Slot(138)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glBufferPageCommitmentARB(OpenTK.Graphics.OpenGL.BufferTargetArb target, IntPtr offset, IntPtr size, bool commit);

            [Slot(1554)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glNamedBufferPageCommitmentARB(uint buffer, IntPtr offset, IntPtr size, bool commit);
        }
    }
}