using System;
using System.ComponentModel;
using System.Diagnostics;

namespace PenseAPI.My
{
    internal static partial class MyProject
    {
        internal partial class MyForms
        {
            [EditorBrowsable(EditorBrowsableState.Never)]
            public TestForm m_TestForm;

            public TestForm TestForm
            {
                [DebuggerHidden]
                get
                {
                    m_TestForm = Create__Instance__(m_TestForm);
                    return m_TestForm;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_TestForm))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_TestForm);
                }
            }
        }
    }
}