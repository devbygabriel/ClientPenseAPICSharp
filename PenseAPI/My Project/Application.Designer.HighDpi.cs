using System;

// This constant indicates whether the Application Framework is in use.
/* TODO ERROR: Skipped DefineDirectiveTrivia
#Const APPLICATION_FRAMEWORK = True
*/
/* TODO ERROR: Skipped IfDirectiveTrivia
#If APPLICATION_FRAMEWORK Then
*/
/* TODO ERROR: Skipped IfDirectiveTrivia
#If NET5_0 And Not NET6_0 Then
*/
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace PenseAPI.My
{
    internal partial class MyApplication
    {
        public event ApplyHighDpiModeEventHandler ApplyHighDpiMode;

        public delegate void ApplyHighDpiModeEventHandler(object sender, ApplyHighDpiModeEventArgs e);

        private HighDpiMode? _highDpiMode;

        internal new HighDpiMode HighDpiMode
        {
            get
            {
                return _highDpiMode is null ? MyProject.Application.HighDpiMode : _highDpiMode.Value;
            }

            set
            {
                _highDpiMode = value;
            }
        }

        // IMPORTANT:
        // If this method causes an compilation error after you've unchecked 'Application Framework' 
        // in the project properties, go to the top of this file and change the value to 'False' in this line:
        // #Const APPLICATION_FRAMEWORK = False

        // For more about using WinForms without the Application Framework 
        // see: https://aka.ms/visualbasic-appframework-net5
        protected override bool OnInitialize(ReadOnlyCollection<string> commandLineArgs)
        {
            var eventArgs = new ApplyHighDpiModeEventArgs(_highDpiMode is null ? HighDpiMode.SystemAware : _highDpiMode.Value);
            ApplyHighDpiMode?.Invoke(this, eventArgs);
            Application.SetHighDpiMode(eventArgs.HighDpiMode);
            return base.OnInitialize(commandLineArgs);
        }
    }

    public class ApplyHighDpiModeEventArgs : EventArgs
    {
        public ApplyHighDpiModeEventArgs(HighDpiMode highDpiMode)
        {
            HighDpiMode = highDpiMode;
        }

        public HighDpiMode HighDpiMode { get; set; }
    }
}

/* TODO ERROR: Skipped EndIfDirectiveTrivia
#End If ' #If NET5_0 And Not NET6_0
*//* TODO ERROR: Skipped EndIfDirectiveTrivia
#End If ' #If APPLICATION_FRAMEWORK
*/