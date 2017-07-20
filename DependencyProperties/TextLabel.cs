using System.Globalization;
using System.Windows;
using System.Windows.Media;

namespace DependencyProperties
{
    public class TextLabel : FrameworkElement
    {
        // Code Snippets:
        // propdp -> DependencyProperty
        // propa  -> AttachedProperty

        public static readonly DependencyProperty FontSizeProperty;
        public static readonly DependencyProperty TextProperty;

        static TextLabel()
        {
            FontSizeProperty = DependencyProperty.Register(
                name: "FontSize",
                propertyType: typeof(double),
                ownerType: typeof(TextLabel),
                typeMetadata: new FrameworkPropertyMetadata(
                    defaultValue: 11.0,
                    flags: FrameworkPropertyMetadataOptions.AffectsMeasure),
                validateValueCallback: v => (double)v > 0);

            TextProperty = DependencyProperty.Register(
                name: "Text",
                propertyType: typeof(string),
                ownerType: typeof(TextLabel), 
                typeMetadata: new FrameworkPropertyMetadata(
                    defaultValue: string.Empty,
                    flags: FrameworkPropertyMetadataOptions.AffectsMeasure |
                           FrameworkPropertyMetadataOptions.AffectsRender));
        }

        public double FontSize
        {
            get => (double)GetValue(FontSizeProperty);
            set => SetValue(FontSizeProperty, value);
        }

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);

            drawingContext.DrawRectangle(Brushes.LightGray, null, new Rect(RenderSize));
            drawingContext.DrawText(GetFormattedText(), new Point(2.5, 2.5));
        }

        protected override Size MeasureOverride(Size availableSize)
        {
            var text = GetFormattedText();
            return new Size(text.Width + 5, text.Height + 5);
        }

        private FormattedText GetFormattedText()
        {
            return new FormattedText(
                Text,
                CultureInfo.InvariantCulture,
                FlowDirection.LeftToRight,
                new Typeface("Arial"),
                FontSize,
                Brushes.Black);
        }
    }
}