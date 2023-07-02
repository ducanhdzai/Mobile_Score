using Xamarin.Forms;

namespace Mobile_Score.Custom
{
    public class BorderLessEntry : Entry
    {
        public static readonly BindableProperty CornerRadius = BindableProperty.Create("ConerRadius", typeof(int), typeof(BorderLessEntry), 0);
        public static readonly BindableProperty BorderColor = BindableProperty.Create("BorderThickness", typeof(Color), typeof(BorderLessEntry), Color.Black);

        public int EntryCornerRadius
        {
            get { return (int)GetValue(CornerRadius); }
            set { SetValue(CornerRadius, value); }
        }
        public Color EntryBorderColor
        {
            get { return (Color)GetValue(BorderColor); }
            set { SetValue(BorderColor, value); }
        }
    }
}
