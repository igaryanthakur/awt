<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BannerSlideshow.aspx.cs" Inherits="AjaxBanner.BannerSlideshow" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <title>Shoe Store - Banner Slideshow</title>
    <style>
        body { font-family: Arial, sans-serif; text-align: center; background: #f5f5f5; }
        h1 { color: #333; margin-top: 30px; }
        .banner-box { margin: 30px auto; width: 600px; background: #fff;
                      border: 2px solid #ddd; border-radius: 8px; padding: 20px; }
        .banner-box img { width: 560px; height: 300px; border-radius: 6px; }
        .caption { font-size: 18px; font-weight: bold; color: #555; margin-top: 10px; }
        .visitor-info { margin-top: 20px; font-size: 14px; color: #888; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <!-- ScriptManager is required for all AJAX controls -->
        <asp:ScriptManager ID="ScriptManager1" runat="server" />

        <h1>ShoeWorld - Latest Collection</h1>

        <!-- UpdatePanel wraps the content to be partially refreshed -->
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <div class="banner-box">
                    <!-- Timer fires every 5 seconds, triggering partial postback -->
                    <asp:Timer ID="Timer1" runat="server" Interval="5000"
                               OnTick="Timer1_Tick" />

                    <asp:Image ID="imgBanner" runat="server" />
                    <div class="caption">
                        <asp:Label ID="lblCaption" runat="server" />
                    </div>
                    <div class="visitor-info">
                        Auto-refreshing every 5 seconds &nbsp;|&nbsp;
                        Slide: <asp:Label ID="lblSlide" runat="server" />
                    </div>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>

        <!-- UpdateProgress shows while postback is processing -->
        <asp:UpdateProgress ID="UpdateProgress1" runat="server">
            <ProgressTemplate>
                <p style="color:gray;">Loading...</p>
            </ProgressTemplate>
        </asp:UpdateProgress>
    </form>
</body>
</html>
