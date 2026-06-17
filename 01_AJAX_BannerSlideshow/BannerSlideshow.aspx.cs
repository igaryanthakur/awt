using System;
using System.Web.UI;

namespace AjaxBanner
{
    public partial class BannerSlideshow : Page
    {
        // Banner data: image URLs and captions
        // In a real project, replace with actual image paths
        private static readonly string[] BannerImages = {
            "https://via.placeholder.com/560x300/FF6B6B/FFFFFF?text=Running+Shoes",
            "https://via.placeholder.com/560x300/4ECDC4/FFFFFF?text=Casual+Sneakers",
            "https://via.placeholder.com/560x300/45B7D1/FFFFFF?text=Formal+Shoes",
            "https://via.placeholder.com/560x300/96CEB4/FFFFFF?text=Sports+Shoes",
            "https://via.placeholder.com/560x300/FFEAA7/333333?text=Kids+Shoes"
        };

        private static readonly string[] BannerCaptions = {
            "Premium Running Shoes - Starting ₹999",
            "Casual Sneakers - Buy 1 Get 1 Free",
            "Formal Collection - Office Ready",
            "Sports Range - For Champions",
            "Kids Collection - Colorful & Durable"
        };

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Initialize slide index in Session
                Session["SlideIndex"] = 0;
                ShowBanner(0);
            }
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            // Get current index from Session and advance it
            int index = (int)(Session["SlideIndex"] ?? 0);
            index = (index + 1) % BannerImages.Length;
            Session["SlideIndex"] = index;
            ShowBanner(index);
        }

        private void ShowBanner(int index)
        {
            imgBanner.ImageUrl = BannerImages[index];
            imgBanner.AlternateText = BannerCaptions[index];
            lblCaption.Text = BannerCaptions[index];
            lblSlide.Text = (index + 1) + " / " + BannerImages.Length;
        }
    }
}
