using Android.Content;
using Android.Graphics.Drawables;
using Mobile_Score.Custom;
using Mobile_Score.Droid.Custom;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
[assembly: ExportRenderer(typeof(BorderLessEntry), typeof(BorderLessEntryAndroid))]
namespace Mobile_Score.Droid.Custom
{
    public class BorderLessEntryAndroid : EntryRenderer
    {

        public BorderLessEntryAndroid(Context context) : base(context)
        {
        }
        BorderLessEntry borderLessEntry;
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null)
            {
                borderLessEntry = (BorderLessEntry)e.NewElement;
                var gradientDrawable = new GradientDrawable();
                gradientDrawable.SetCornerRadius(borderLessEntry.EntryCornerRadius);
                gradientDrawable.SetStroke(2, borderLessEntry.EntryBorderColor.ToAndroid());
                Control.SetBackground(gradientDrawable);
            }
        }
    }
}