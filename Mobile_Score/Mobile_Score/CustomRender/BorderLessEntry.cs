using Xamarin.Forms;

namespace Mobile_Score.CustomRender
{
    public class BorderLessEntry : Entry
    {
        public static readonly BindableProperty CornerRadius = BindableProperty.Create("ConerRadius", typeof(int), typeof(BorderLessEntry), 0);
        public int EntryCornerRadius
        {
            get { return (int)GetValue(CornerRadius); }
            set { SetValue(CornerRadius, value); }
        }
    }
}
