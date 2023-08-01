using LiveSplit.Model;
using System;

namespace LiveSplit.UI.Components
{
    public class TotalGoldFactory : IComponentFactory
    {
        // The displayed name of the component in the Layout Editor.
        public string ComponentName => "Total Gold This Run";

        public string Description => "Displays how much the Sum of Best has been lowered this run, or this session.";

        // The sub-menu this component will appear under when adding the component to the layout.
        public ComponentCategory Category => ComponentCategory.Information;

        public IComponent Create(LiveSplitState state) => new TotalGoldComponent(state);

        public string UpdateName => ComponentName;

        // Fill in this empty string with the URL of the repository where your component is hosted.
        // This should be the raw content version of the repository. If you're not uploading this
        // to GitHub or somewhere, you can ignore this.
        public string UpdateURL => "https://raw.githubusercontent.com/UNHchabo/LiveSplit.TotalGold/master/";

        // Fill in this empty string with the path of the XML file containing update information.
        // Check other LiveSplit components for examples of this. If you're not uploading this to
        // GitHub or somewhere, you can ignore this.
        public string XMLURL => UpdateURL + "Components/update.LiveSplit.TotalGold.xml";

        public Version Version => System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
    }
}