using LiveSplit.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace LiveSplit.UI.Components
{
    // Component created using the tutorial found here:
    // https://gist.github.com/TheSoundDefense/cf85fd68ae582faa5f1cc95f18bba4ec
    public class TotalGoldComponent : IComponent
    {
        // This internal component does the actual heavy lifting. Whenever we want to do something
        // like display text, we will call the appropriate function on the internal component.
        protected InfoTextComponent InternalComponent { get; set; }
        // This is how we will access all the settings that the user has set.
        public TotalGoldSettings Settings { get; set; }
        // This object contains all of the current information about the splits, the timer, etc.
        protected LiveSplitState CurrentState { get; set; }

        protected TimeSpan GoldThisRun { get; set; }
        protected TimeSpan? StartingSumOfBest { get; set; }
        protected TimeSpan? CurrentSumOfBest { get; set; }
        protected bool CurrentTotalValid { get; set; }

        public string ComponentName => "Total Gold";

        public float HorizontalWidth => InternalComponent.HorizontalWidth;
        public float MinimumWidth => InternalComponent.MinimumWidth;
        public float VerticalHeight => InternalComponent.VerticalHeight;
        public float MinimumHeight => InternalComponent.MinimumHeight;

        public float PaddingTop => InternalComponent.PaddingTop;
        public float PaddingLeft => InternalComponent.PaddingLeft;
        public float PaddingBottom => InternalComponent.PaddingBottom;
        public float PaddingRight => InternalComponent.PaddingRight;

        // I'm going to be honest, I don't know what this is for, but I know we don't need it.
        public IDictionary<string, Action> ContextMenuControls => null;

        // This function is called when LiveSplit creates your component. This happens when the
        // component is added to the layout, or when LiveSplit opens a layout with this component
        // already added.
        public TotalGoldComponent(LiveSplitState state)
        {
            Settings = new TotalGoldSettings();
            InternalComponent = new InfoTextComponent("Total Gold", "-");
            StartingSumOfBest = SumOfBest.CalculateSumOfBest(state.Run);
            CurrentSumOfBest = StartingSumOfBest;
            GoldThisRun = new TimeSpan(0);
            
            CurrentTotalValid = false;

            state.OnStart += state_OnStart;
            state.OnSplit += state_OnSplitChange;
            state.OnSkipSplit += state_OnSplitChange;
            state.OnUndoSplit += state_OnSplitChange;
            state.OnReset += state_OnReset;
            CurrentState = state;
        }

        public void DrawHorizontal(Graphics g, LiveSplitState state, float height, Region clipRegion)
        {
            InternalComponent.NameLabel.HasShadow
                = InternalComponent.ValueLabel.HasShadow
                = state.LayoutSettings.DropShadows;

            InternalComponent.NameLabel.ForeColor = state.LayoutSettings.TextColor;
            InternalComponent.ValueLabel.ForeColor = state.LayoutSettings.TextColor;

            InternalComponent.DrawHorizontal(g, state, height, clipRegion);
        }

        // We will be adding the ability to display the component across two rows in our settings menu.
        public void DrawVertical(Graphics g, LiveSplitState state, float width, Region clipRegion)
        {
            InternalComponent.DisplayTwoRows = Settings.Display2Rows;

            InternalComponent.NameLabel.HasShadow
                = InternalComponent.ValueLabel.HasShadow
                = state.LayoutSettings.DropShadows;

            InternalComponent.NameLabel.ForeColor = state.LayoutSettings.TextColor;
            InternalComponent.ValueLabel.ForeColor = state.LayoutSettings.TextColor;

            InternalComponent.DrawVertical(g, state, width, clipRegion);
        }

        public Control GetSettingsControl(LayoutMode mode)
        {
            Settings.Mode = mode;
            return Settings;
        }

        public System.Xml.XmlNode GetSettings(System.Xml.XmlDocument document)
        {
            return Settings.GetSettings(document);
        }

        public void SetSettings(System.Xml.XmlNode settings)
        {
            Settings.SetSettings(settings);
        }

        // This is the function where we decide what needs to be displayed at this moment in time,
        // and tell the internal component to display it. This function is called hundreds to
        // thousands of times per second.
        public void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode)
        {
            if (!CurrentTotalValid)
            {
                CurrentTotalValid = true;
                CurrentSumOfBest = SumOfBest.CalculateSumOfBest(CurrentState.Run);
                if (CurrentSumOfBest.HasValue && StartingSumOfBest.HasValue)
                {
                    GoldThisRun = StartingSumOfBest.Value - CurrentSumOfBest.Value;
                }
                string totalGoldFormat = $"{GoldThisRun.TotalSeconds:0}";
                if (Settings.Accuracy.Equals(TotalGoldSettings.TotalGoldAccuracy.Tenths))
                {
                    totalGoldFormat = $"{GoldThisRun.TotalSeconds:0.#}";
                }
                else if (Settings.Accuracy.Equals(TotalGoldSettings.TotalGoldAccuracy.Hundredths))
                {
                    totalGoldFormat = $"{GoldThisRun.TotalSeconds:0.##}";
                }
                System.Diagnostics.Trace.WriteLine("Gold: " + totalGoldFormat);
                InternalComponent.InformationValue = totalGoldFormat;
            }
            InternalComponent.Update(invalidator, state, width, height, mode);
        }

        // This function is called when the component is removed from the layout, or when LiveSplit
        // closes a layout with this component in it.
        public void Dispose()
        {
            CurrentState.OnStart -= state_OnStart;
            CurrentState.OnSplit -= state_OnSplitChange;
            CurrentState.OnSkipSplit -= state_OnSplitChange;
            CurrentState.OnUndoSplit -= state_OnSplitChange;
            CurrentState.OnReset -= state_OnReset;
        }

        // I do not know what this is for.
        public int GetSettingsHashCode() => Settings.GetSettingsHashCode();

        void state_OnStart(object sender, EventArgs e)
        {
            StartingSumOfBest = SumOfBest.CalculateSumOfBest(CurrentState.Run);
            CurrentSumOfBest = StartingSumOfBest;
            CurrentTotalValid = false;
        }

        void state_OnSplitChange(object sender, EventArgs e)
        {
            CurrentTotalValid = false;
        }

        void state_OnReset(object sender, TimerPhase e)
        {
            StartingSumOfBest = SumOfBest.CalculateSumOfBest(CurrentState.Run);
            CurrentSumOfBest = StartingSumOfBest;
            CurrentTotalValid = false;
        }
    }

}