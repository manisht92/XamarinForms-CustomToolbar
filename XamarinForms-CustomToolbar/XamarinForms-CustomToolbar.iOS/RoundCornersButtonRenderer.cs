using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamarinForms_CustomToolbar.iOS;
using XamarinFormsCustomToolbar.Controls;

[assembly: ExportRenderer(typeof(RoundCornersButton), typeof(RoundCornersButtonRenderer))]
namespace XamarinForms_CustomToolbar.iOS
{
    public class RoundCornersButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.Layer.CornerRadius = 22;
                Control.Layer.ShadowRadius = 10;
                Control.ClipsToBounds = true;
            }
        }
    }
}
